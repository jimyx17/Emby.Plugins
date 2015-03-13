﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace MediaBrowser.Plugins.GoogleDrive
{
    public interface IGoogleDriveService
    {
        Task<string> UploadFile(Stream stream, GoogleDriveFile googleDriveFile, GoogleCredentials googleCredentials, IProgress<double> progress, CancellationToken cancellationToken);
        Task DeleteFile(GoogleDriveFile googleDriveFile, GoogleCredentials googleCredentials, CancellationToken cancellationToken);
        Task<Stream> GetFile(GoogleDriveFile googleDriveFile, GoogleCredentials googleCredentials, CancellationToken cancellationToken);
        Task<IEnumerable<GoogleDriveFile>> GetFilesListing(string googleDrivefolder, GoogleCredentials googleCredentials, CancellationToken cancellationToken);
    }
}
