using System;
using System.Collections.Generic;
namespace SimpsonsSystem.Backend.Database
{
    public class StockDBAccess:IDisposable
    {
        ///<summary>
        ///  A class containing methods and properties useful to the
        ///  management an interaction with the Stock table in the database
        ///</summary>
        #region Public Constructor
        public StockDBAccess(Classes.ClsDatabase _db){db=_db;}
        #endregion
        #region Private Variables
        private readonly Classes.ClsDatabase db;
        #endregion
        #region Public Methods
        public System.Data.DataTable ApplyFilterDGV(System.Windows.Forms.Button b, bool searchByFastMoving)
        {
            switch (b.Name)
            {
                case "btnBedding":
                    {
                        if (searchByFastMoving)
                        {
                            return SearchByCategoryDGV("Bedding", true);
                        }
                        else
                        {
                            return SearchByCategoryDGV("Bedding", false);
                        }
                    }
                case "btnCutlery":
                    {
                        if (searchByFastMoving)
                        {
                            return SearchByCategoryDGV("Cutlery", true);
                        }
                        else
                        {
                            return SearchByCategoryDGV("Cutlery", false);
                        }
                    }
                case "btnAppliances":
                    {
                        if (searchByFastMoving)
                        {
                            return SearchByCategoryDGV("Appliances", true);
                        }
                        else
                        {
                            return SearchByCategoryDGV("Appliances", false);
                        }
                    }
                case "btnChina":
                    {
                        if (searchByFastMoving)
                        {
                            return SearchByCategoryDGV("China", true);
                        }
                        else
                        {
                            return SearchByCategoryDGV("China", false);
                        }
                    }
                case "btnFastMoving":
                    {
                        return SearchByFastMovingDGV();
                    }
                case "btnClearFilters":
                    {
                        return GetDataTableStock();
                    }
            }
            return null;
        }
        public List<Classes.ClsStock> ApplyFilterList(System.Windows.Forms.Button b, bool searchByFastMoving)
        {
            switch (b.Name)
            {
                case "btnBedding":
                    {
                        if (searchByFastMoving)
                        {
                            return SearchByCategoryList("Bedding", true);
                        }
                        else
                        {
                            return SearchByCategoryList("Bedding", false);
                        }
                    }
                case "btnCutlery":
                    {
                        if (searchByFastMoving)
                        {
                            return SearchByCategoryList("Cutlery", true);
                        }
                        else
                        {
                            return SearchByCategoryList("Cutlery", false);
                        }
                    }
                case "btnAppliances":
                    {
                        if (searchByFastMoving)
                        {
                            return SearchByCategoryList("Appliances", true);
                        }
                        else
                        {
                            return SearchByCategoryList("Appliances", false);
                        }
                    }
                case "btnChina":
                    {
                        if (searchByFastMoving)
                        {
                            return SearchByCategoryList("China", true);
                        }
                        else
                        {
                            return SearchByCategoryList("China", false);
                        }
                    }
                case "btnFastMoving":
                    {
                        return SearchByFastMovingList();
                    }
            }
            return null;
        }
        //returns a list of all Backend.Classes.ClsStock objects from the database
        public List<Classes.ClsStock>GetStockObjects()
        {
            string SQLCmd="SELECT * FROM Stock";
            Classes.ClsSystem.RunSQLSelect(SQLCmd,db);
            return GetStockListFromRdr();
        }
        public System.Data.DataTable SearchByCategoryDGV(string category, bool moving)
        {
            string SQLCmd;
            if (moving)
            {
                SQLCmd = "SELECT StockName as Name, StockDescription as Description, StockAmountHeld as Amount_Held, StockRestockValue, StockPrice as Stock_Price, ManufacturerName as Manufacturer, StockCategory as Category FROM STOCK INNER JOIN Manufacturer ON Manufacturer.ManufacturerId = Stock.ManufacturerId WHERE StockCategory = '" + category + "' WHERE (SUM(PurchaseBridgeStock.Amount)*Stock.StockMovingValue) <= 10 AND DATEDIFF(DAY,GETDATE(),Purchase.DateOfPurchase) <=31;";
            }
            else
            {
                SQLCmd = "SELECT StockName as Name, StockDescription as Description, StockAmountHeld as Amount_Held, StockRestockValue, StockPrice as Stock_Price, ManufacturerName as Manufacturer, StockCategory as Category FROM STOCK INNER JOIN Manufacturer ON Manufacturer.ManufacturerId = Stock.ManufacturerId WHERE StockCategory = '" + category+"';";
            }
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return Classes.ClsSystem.GetDataTable(db);
        }
        public List<Classes.ClsStock> SearchByCategoryList(string category, bool moving)
        {
            string SQLCmd;
            if (moving)
            {
                SQLCmd = "SELECT * FROM STOCK WHERE StockCategory = '" + category + "' WHERE (SUM(PurchaseBridgeStock.Amount)*Stock.StockMovingValue) <= 10 AND DATEDIFF(DAY,GETDATE(),Purchase.DateOfPurchase) <=31;";
            }
            else
            {
                SQLCmd = "SELECT * FROM STOCK WHERE StockCategory = '" + category + "';";
            }
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return Classes.ClsSystem.GetListStockFromRdr(db);
        }
        public System.Data.DataTable SearchByFastMovingDGV()
        {
            string SQLCmd = "SELECT StockName as Name, StockDescription as Description, StockAmountHeld as Amount_Held, StockRestockValue, StockPrice as Stock_Price, ManufacturerName as Manufacturer, StockCategory as Category FROM STOCK INNER JOIN Manufacturer ON Manufacturer.ManufacturerId = Stock.ManufacturerId INNER JOIN PurchaseBridgeStock ON Stock.StockId = PurchaseBridgeStock.StockId WHERE DATEDIFF(DAY,GETDATE(),Purchase.DateOfPurchase) <=31 HAVING (SUM(PurchaseBridgeStock.Amount)*Stock.StockMovingValue) <= 10;";
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return Classes.ClsSystem.GetDataTable(db);
        }
        public List<Classes.ClsStock> SearchByFastMovingList()
        {
            string SQLCmd = "SELECT * INNER JOIN PurchaseBridgeStock ON Stock.StockId = PurchaseBridgeStock.StockId WHERE (SUM(PurchaseBridgeStock.Amount)*Stock.StockMovingValue) <= 10 AND DATEDIFF(DAY,GETDATE(),Purchase.DateOfPurchase) <=31;";
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return Classes.ClsSystem.GetListStockFromRdr(db);
        }
        //returns a list of all Stock registers as a datatable from the database
        public System.Data.DataTable GetDataTableStock()
        {
            string SQLCmd = "SELECT StockName as Name, StockDescription as Description, StockAmountHeld as Amount_Held, StockRestockValue, StockPrice as Stock_Price, ManufacturerName as Manufacturer, StockCategory as Category FROM STOCK INNER JOIN Manufacturer ON Manufacturer.ManufacturerId = Stock.ManufacturerId;";
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return Classes.ClsSystem.GetDataTable(db);
        }
        //Returns a list of all Backend.Classes.ClsStock objects under a search of name/manufcutrer
        public List<Classes.ClsStock> SearchByModelManufacturer(string se)
        {
            string SQLCmd= "SELECT * FROM Stock INNER JOIN Manufacturer ON Manufacturer.ManufacturerId = Stock.ManufacturerId WHERE StockName LIKE '%" + se + "%' Or ManufacturerName like '%" + se + "%' ORDER BY StockName";
            Classes.ClsSystem.RunSQLSelect(SQLCmd,db);
            return GetStockListFromRdr();
        }
        //Returns a datatable containing registers under a search of name/manufcutrer
        public System.Data.DataTable SearchByModelManufacturerDataTable(string se)
        {
            string SQLCmd = "SELECT StockName as Name, StockDescription as Description, StockAmountHeld as Amount_Held, StockRestockValue, StockPrice as Stock_Price, ManufacturerName as Manufacturer, StockCategory as Category FROM STOCK INNER JOIN Manufacturer ON Manufacturer.ManufacturerId = Stock.ManufacturerId WHERE StockName LIKE '%" + se + "%' Or ManufacturerName like '%" + se + "%' ORDER BY StockName;";
            Classes.ClsSystem.RunSQLSelect(SQLCmd, db);
            return Classes.ClsSystem.GetDataTable(db);
        }
        //Return the manufacturer name from Stock where the id is equal to the input.
        public string GetManufacturerName(int id)
        {
            string SQLCmd="SELECT Manufacturer.ManufacturerName FROM Stock INNER JOIN Manufacturer ON Manufacturer.ManufacturerId=Stock.ManufacturerId WHERE Stock.ManufacturerId="+Convert.ToString(id);
            Classes.ClsSystem.RunSQLSelect(SQLCmd,db);
            return Classes.ClsSystem.GetStringFromRdr(db);
        }
        //Decrease amount by an amount given
        public void UpdateAmount(int a)
        {
            string SQLCmd = "UPDATE Stock SET StockAmountHeld = StockAmountHeld + "+a+";";
            Classes.ClsSystem.RunSQLNonSelect(SQLCmd, db);
        }
        #endregion
        #region Private Methods
        private List<Classes.ClsStock> GetStockListFromRdr()
        {
            List<Classes.ClsStock> l = new();
            while (db.Rdr.Read())
            {
                int id = db.Rdr.GetInt32(0);
                string desc = db.Rdr.GetString(1);
                string name = db.Rdr.GetString(2);
                int amount = db.Rdr.GetInt32(3);
                int restockValue = db.Rdr.GetInt32(4);
                decimal price = db.Rdr.GetDecimal(5);
                string stockCategory = db.Rdr.GetString(6);
                int manid = db.Rdr.GetInt32(7);
                int stockMovingValue = db.Rdr.GetInt32(8);
                Classes.ClsStock s = new(id, name, desc, price, manid, amount, restockValue,stockMovingValue,stockCategory);
                l.Add(s);
            }
            return l;
        }
        #endregion
        #region Idisposable Interface Methods
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
        }
        #endregion
    }
}
