using System;
using System.Data;

namespace AutoLevelDbHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet dataSet = new DataSet("OnlineShop");
            DataTable userTable = new DataTable("User");
            DataColumn idColumn = new DataColumn();
            idColumn.ColumnName = "Id";
            idColumn.DataType = typeof(int);
            idColumn.AllowDBNull = false;
            idColumn.AutoIncrement = true;
            idColumn.Unique = true;

            DataColumn nameColumn = new DataColumn();
            nameColumn.ColumnName = "Name";
            nameColumn.DataType = typeof(string);
            nameColumn.AllowDBNull = false;
            nameColumn.Unique = true;
            nameColumn.MaxLength = 20;

            DataColumn loginColumn = new DataColumn();
            loginColumn.ColumnName = "Login";
            loginColumn.DataType = typeof(string);
            loginColumn.AllowDBNull = false;
            loginColumn.Unique = true;
            loginColumn.MaxLength = 20;

            DataColumn passwordColumn = new DataColumn();
            passwordColumn.ColumnName = "Password";
            passwordColumn.DataType = typeof(string);
            passwordColumn.AllowDBNull = false;
            passwordColumn.Unique = true;
            passwordColumn.MaxLength = 10;

            userTable.Columns.Add(idColumn);
            userTable.Columns.Add(nameColumn);
            userTable.Columns.Add(loginColumn);
            userTable.Columns.Add(passwordColumn);

            dataSet.Tables.Add(userTable);

            DataTable productTable = new DataTable("Product");
            idColumn.ColumnName = "Id";
            idColumn.DataType = typeof(int);
            idColumn.AllowDBNull = false;
            idColumn.AutoIncrement = true;
            idColumn.Unique = true;

            nameColumn.ColumnName = "Name";
            nameColumn.DataType = typeof(string);
            nameColumn.AllowDBNull = false;
            nameColumn.Unique = true;
            nameColumn.MaxLength = 20;

            DataColumn titleColumn = new DataColumn();
            titleColumn.ColumnName = "Title";
            titleColumn.DataType = typeof(string);
            titleColumn.AllowDBNull = false;
            titleColumn.Unique = true;
            titleColumn.MaxLength = 200;

            DataColumn priceColumn = new DataColumn();
            priceColumn.ColumnName = "Price";
            priceColumn.DataType = typeof(int);
            priceColumn.AllowDBNull = false;
            priceColumn.Unique = true;

            productTable.Columns.Add(idColumn);
            productTable.Columns.Add(nameColumn);
            productTable.Columns.Add(titleColumn);
            productTable.Columns.Add(priceColumn);

            dataSet.Tables.Add(productTable);

            DataTable categotiesTable = new DataTable("Categoties");
            idColumn.ColumnName = "Id";
            idColumn.DataType = typeof(int);
            idColumn.AllowDBNull = false;
            idColumn.AutoIncrement = true;
            idColumn.Unique = true;

            nameColumn.ColumnName = "Name";
            nameColumn.DataType = typeof(string);
            nameColumn.AllowDBNull = false;
            nameColumn.Unique = true;
            nameColumn.MaxLength = 20;

            DataColumn productId = new DataColumn();
            productId.ColumnName = "ProductId";
            productId.DataType = typeof(int);
            productId.AllowDBNull = false;

            categotiesTable.Columns.Add(idColumn);
            categotiesTable.Columns.Add(nameColumn);
            categotiesTable.Columns.Add(productId);

            dataSet.Tables.Add(categotiesTable);

            DataRelation relation = new DataRelation("product_categories_ralation", "Product", "Categoties", new string[] { "Id" }, new string[] { "ProductId" }, false);
            dataSet.Relations.Add(relation);
        }
    }
}
