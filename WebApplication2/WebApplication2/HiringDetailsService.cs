
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication2.Models;

public class HiringDetailsService
{
    private readonly MANAGEMENT_BPMContext _context; // Replace 'YourDbContext' with your actual DbContext

    public HiringDetailsService(MANAGEMENT_BPMContext context)
    {
        _context = context;
    }

    // Method to add a new hiring detail
    public async Task<bool> AddHiringDetail(HiringDetails hiringDetail)
    {
        var parameters = new[]
        {
            new SqlParameter("@TaskID", hiringDetail.TaskID),
            new SqlParameter("@ResponsibleUserID", hiringDetail.ResponsibleUserID),
            new SqlParameter("@ResponsibleUserName", hiringDetail.ResponsibleUserName),
            new SqlParameter("@HireName", hiringDetail.HireName),
            new SqlParameter("@Department", hiringDetail.Department),
            new SqlParameter("@StepDescription", hiringDetail.StepDescription),
            new SqlParameter("@Status", hiringDetail.Status),
            new SqlParameter("@CompletionDate", hiringDetail.CompletionDate ?? (object)DBNull.Value),
             new SqlParameter("@UserName2", hiringDetail.UserName2 ?? (object)DBNull.Value),
            new SqlParameter("@UserName3", hiringDetail.UserName3 ?? (object)DBNull.Value),
            new SqlParameter("@Status2", hiringDetail.Status2 ?? (object)DBNull.Value),
            new SqlParameter("@Status3", hiringDetail.Status3 ?? (object)DBNull.Value),
            new SqlParameter("@CompletionDate2", hiringDetail.CompletionDate2 ?? (object)DBNull.Value),
            new SqlParameter("@CompletionDate3", hiringDetail.CompletionDate3 ?? (object)DBNull.Value),

        };

        int result = await _context.Database.ExecuteSqlRawAsync("EXEC sp_InsertHiringDetail @TaskID, @ResponsibleUserID, @ResponsibleUserName, @HireName, @Department, @StepDescription, @Status, @CompletionDate", parameters);
        return result > 0;
    }

    // Method to update an existing hiring detail
    public async Task<bool> UpdateHiringDetail(HiringDetails hiringDetail)
    {
        var parameters = new[]
        {
            new SqlParameter("@DetailID", hiringDetail.DetailID),
            new SqlParameter("@TaskID", hiringDetail.TaskID),
            new SqlParameter("@ResponsibleUserID", hiringDetail.ResponsibleUserID),
            new SqlParameter("@ResponsibleUserName", hiringDetail.ResponsibleUserName),
            new SqlParameter("@HireName", hiringDetail.HireName),
            new SqlParameter("@Department", hiringDetail.Department),
            new SqlParameter("@StepDescription", hiringDetail.StepDescription),
            new SqlParameter("@Status", hiringDetail.Status),
            new SqlParameter("@CompletionDate", hiringDetail.CompletionDate ?? (object)DBNull.Value),
            new SqlParameter("@UserName2", hiringDetail.UserName2 ?? (object)DBNull.Value),
            new SqlParameter("@UserName3", hiringDetail.UserName3 ?? (object)DBNull.Value),
            new SqlParameter("@Status2", hiringDetail.Status2 ?? (object)DBNull.Value),
            new SqlParameter("@Status3", hiringDetail.Status3 ?? (object)DBNull.Value),
            new SqlParameter("@CompletionDate2", hiringDetail.CompletionDate2 ?? (object)DBNull.Value),
            new SqlParameter("@CompletionDate3", hiringDetail.CompletionDate3 ?? (object)DBNull.Value),

        };

        int result = await _context.Database.ExecuteSqlRawAsync("EXEC sp_UpdateHiringDetail @DetailID, @TaskID, @ResponsibleUserID, @ResponsibleUserName, @HireName, @Department, @StepDescription, @Status, @CompletionDate", parameters);
        return result > 0;
    }

    // Method to delete a hiring detail
    public async Task<bool> DeleteHiringDetail(int detailID)
    {
        var parameter = new SqlParameter("@DetailID", detailID);
        int result = await _context.Database.ExecuteSqlRawAsync("EXEC sp_DeleteHiringDetail @DetailID", parameter);
        return result > 0;
    }

    public async Task<HiringDetails> GetHiringDetail(int id)
    {
        var query = $"SELECT * FROM HiringDetails WHERE DetailID = {id}";
        var hiringDetails = await _context.HiringDetails
                                          .FromSqlRaw(query)
                                          .AsNoTracking() // Use AsNoTracking for read-only operations
                                          .SingleOrDefaultAsync(); // Correct method for async

        return hiringDetails;
    }
    public async Task<List<HiringDetails>> GetHiringDetailsByTaskId(int taskId)
    {
        var query = "SELECT * FROM HiringDetails WHERE TaskID = {0}";
        return await _context.HiringDetails
                             .FromSqlRaw(query, taskId)
                             .ToListAsync();
    }

    // Method to list all hiring details
    public async Task<List<HiringDetails>> GetAllHiringDetails()
    {
        var hiringDetails = await _context.HiringDetails
                                         .FromSqlRaw("EXEC sp_GetAllHiringDetails")
                                         .ToListAsync();
        return hiringDetails;
    }
}
