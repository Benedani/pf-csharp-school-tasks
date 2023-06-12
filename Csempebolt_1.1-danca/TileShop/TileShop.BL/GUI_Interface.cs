using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using TileShop.Types;

namespace TileShop.BL
{
    public static class GUI_Interface
    {
        public enum ShopDataSource
        {
            DataCsempeCSV
        }
        public enum OrderResult
        {
            OK, Error
        }

        static Tile[] GetTiles(ShopDataSource source)
        {
            switch (source)
            {
                case ShopDataSource.DataCsempeCSV:
                    return Tile.LoadCSV("Data-Csempe.csv", ',', 1);
            }
            return null;
        }

        public static Dictionary<int, string[]> GetShopData(ShopDataSource source, string[] fields)
        {
            Tile[] tiles = GetTiles(source);

            PropertyInfo[] propInfos = fields.Select(field => typeof(Tile).GetProperty(field, BindingFlags.Public | BindingFlags.Instance)).ToArray();

            return tiles.ToDictionary(tile => tile.ID, tile => propInfos.Select(p => p.GetValue(tile).ToString()).ToArray());
        }

        public static OrderResult Order(ShopDataSource source, string name, string address, Dictionary<int, int> order, out string information)
        {
            try
            {
                Tile[] tiles = GetTiles(source);
                Dictionary<int, Tile> tilesDict = tiles.ToDictionary(t => t.ID, t => t);

                // TODO: Store order in the database

                string nl = Environment.NewLine;
                information = $"Customer details:{nl}\tName: {name}{nl}\tAddress: {address}{nl}{nl}" +
                    $"Items:{nl}{string.Join(nl, order.Select(kvp => $"{kvp.Value}x {tilesDict[kvp.Key].Name} -- {tilesDict[kvp.Key].Price * kvp.Value:N0} HUF"))}{nl}{nl}" +
                    $"Total: {order.Sum(kvp => tilesDict[kvp.Key].Price * kvp.Value):N0} HUF{nl}{nl}" +
                    $"Delivery time: {(order.Any(kvp => kvp.Value > tilesDict[kvp.Key].Quantity) ? "2-3 weeks" : "1-2 days")}";

                return OrderResult.OK;
            }
            catch (Exception e)
            {
                information = e.ToString();
                return OrderResult.Error;
            }
        }
    }
}
