﻿using Microsoft.AspNetCore.Http;
using RestWithASPNet.Data.VO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestWithASPNet.Business
{
    public interface IFileBusiness
    {

        public byte[] GetFile(string fileName);

        public Task<FileDetailVO> SaveFileToDisk(IFormFile file);

        public Task<List<FileDetailVO>> SaveFilesToDisk(IList<IFormFile> file);
    }
}
