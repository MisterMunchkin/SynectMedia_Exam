using CodingAssignment.Models;
using CodingAssignment.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.IO;

namespace CodingAssignment.Services
{
    public class FileManagerService : IFileManagerService
    {
        public DataFileModel GetData()
        {
            var dataFileModel = JsonConvert.DeserializeObject<DataFileModel>(File.ReadAllText("./AppData/DataFile.json"));

            return dataFileModel;
        }

        public DataModel GetData(int id)
        {
            var dataFileModel = JsonConvert.DeserializeObject<DataFileModel>(File.ReadAllText("./AppData/DataFile.json"));

            var result = dataFileModel.Data.Find(d => d.Id == id);

            return result;
        }

        //Changed the return because the return in FileController for Post is DataFileModel. where would I get the data if I return bool here
        //Insert should not allow to insert if id already exists
        public DataFileModel Insert(DataModel model)
        {
            var dataFileModel = JsonConvert.DeserializeObject<DataFileModel>(File.ReadAllText("./AppData/DataFile.json"));

            var jsonDataModel = dataFileModel.Data.Find(d => d.Id == model.Id);

            if (jsonDataModel == null)
            {
                dataFileModel.Data.Add(model);

                Save(dataFileModel);

                return dataFileModel;
            }
            else
            {
                return null;
            }
        }


        //Changed the return because the return in FileController for Post is DataFileModel. where would I get the data if I return bool here
        public DataFileModel Update(DataModel model, int id)
        {
            var dataFileModel = JsonConvert.DeserializeObject<DataFileModel>(File.ReadAllText("./AppData/DataFile.json"));

            DataModel dataModel = dataFileModel.Data.Find(d => d.Id == id);

            if (dataModel != null)
            {
                dataFileModel.Data.Remove(dataModel);

                dataFileModel.Data.Add(model);

                Save(dataFileModel);

                return dataFileModel;
            }
            else
            {
                return null;
            }
        }


        //Changed the return because the return in FileController for Post is DataFileModel. where would I get the data if I return bool here
        public DataFileModel Delete(int id)
        {
            var dataFileModel = JsonConvert.DeserializeObject<DataFileModel>(File.ReadAllText("./AppData/DataFile.json"));

            DataModel dataModel = dataFileModel.Data.Find(d => d.Id == id);

            if (dataModel != null)
            {
                dataFileModel.Data.Remove(dataModel);

                Save(dataFileModel);

                return dataFileModel;
            }
            else
            {
                return null;
            }
        }

        private void Save(DataFileModel dataFileModel)
        {
            var jsonData = JsonConvert.SerializeObject(dataFileModel, Formatting.Indented);
            File.WriteAllText("./AppData/DataFile.json", jsonData);
        }
    }
}