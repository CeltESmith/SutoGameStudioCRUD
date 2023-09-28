using CRUDApps.DataAccess.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDApps.DataAccess.EF.Models;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace CRUDApps.DataAccess.EF.Repositories
{
    public class LoyaltyChartRepository
    {
        private SutoGameStudioContext _dbContext;

        public LoyaltyChartRepository(SutoGameStudioContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int Create(LoyaltyChart loyaltyChart)
        {
            _dbContext.Add(loyaltyChart);
            _dbContext.SaveChanges();

            return loyaltyChart.LoyaltyChartId;
        }

        public int Update(LoyaltyChart loyaltyChart)
        {
            LoyaltyChart existingLoyalty = _dbContext.LoyaltyChart.Find(loyaltyChart.LoyaltyChartId);

            existingLoyalty.UserName = loyaltyChart.UserName;
            existingLoyalty.OwnFpsblastGame = loyaltyChart.OwnFpsblastGame;
            existingLoyalty.OwnMmoslasherGame = loyaltyChart.OwnMmoslasherGame;
            existingLoyalty.OwnRpgstoryMakerGame = loyaltyChart.OwnRpgstoryMakerGame;
            existingLoyalty.IsLoyalCustomer = loyaltyChart.IsLoyalCustomer;

            _dbContext.SaveChanges();

            return existingLoyalty.LoyaltyChartId;
        }

        public bool Delete(int loyaltyChartId)
        {
            LoyaltyChart loyaltyChart = _dbContext.LoyaltyChart.Find(loyaltyChartId);
            _dbContext.Remove(loyaltyChart);
            _dbContext.SaveChanges();

            return true;
        }

        public List<LoyaltyChart> GetAllLoyaltyCharts()
        {
            List<LoyaltyChart> loyaltyCharts = _dbContext.LoyaltyChart.ToList();

            return loyaltyCharts;
        }

        public LoyaltyChart GetLoyaltyChartByID(int loyaltyChartID)
        {
            LoyaltyChart loyaltyChart = _dbContext.LoyaltyChart.Find(loyaltyChartID);

            return loyaltyChart;
        }
    }
}
