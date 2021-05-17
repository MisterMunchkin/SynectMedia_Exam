using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingAssignment.Models;

namespace CodingAssignment.Services.Interfaces
{
    public interface IFileManagerService
    {
        ///<summary>
        /// Returns the complete data model using id as a parameter
        /// </summary>
        /// <returns></returns>
        DataModel GetData(int id);

        /// <summary>
        /// Returns the complete data model 
        /// </summary>
        /// <returns></returns>
        DataFileModel GetData();

        /// <summary>
        /// Insert new data model 
        /// </summary>
        /// <returns></returns>
        DataFileModel Insert(DataModel model);

        /// <summary>
        /// Updates a specific data model using the id as the key
        /// </summary>
        /// <returns></returns>
        DataFileModel Update(DataModel model, int id);

        /// <summary>
        /// Deletes a specific data model using the id as the key
        /// </summary>
        /// <returns></returns>
        DataFileModel Delete(int id);
    }
}
