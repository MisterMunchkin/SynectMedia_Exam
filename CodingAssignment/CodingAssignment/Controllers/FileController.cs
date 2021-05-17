using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingAssignment.Models;
using CodingAssignment.Services;
using CodingAssignment.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CodingAssignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {

        private IFileManagerService _fileManager;

        public FileController(IFileManagerService fileManager)
        {
            this._fileManager = fileManager;
        }

        [HttpGet]
        public DataFileModel Get()
        {
            //Not yet implemented 
            DataFileModel data = _fileManager.GetData();

            return data;
        }

        [HttpGet("{id}")]
        public DataModel Get(int id)
        {
            DataModel result = _fileManager.GetData(id);

            return result;
        }

        [HttpPost]
        public DataFileModel Post(DataModel model)
        {
            //Not yet implemented 
            DataFileModel result = _fileManager.Insert(model);

            return result;
        }

        [HttpPut]
        public DataFileModel Put(DataModel model, int id)
        {
            //Not yet implemented 
            DataFileModel result = _fileManager.Update(model, id);

            return result;
        }

        [HttpDelete]
        public DataFileModel Delete(int id)
        {
            //Not yet implemented 
            DataFileModel result = _fileManager.Delete(id);

            return result;
        }
    }
}
