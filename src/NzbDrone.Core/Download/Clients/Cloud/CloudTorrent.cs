using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;
using NLog;
using NzbDrone.Common.Disk;
using NzbDrone.Common.Http;
using NzbDrone.Core.Configuration;
using NzbDrone.Core.MediaFiles.TorrentInfo;
using NzbDrone.Core.Organizer;
using NzbDrone.Core.Parser.Model;
using NzbDrone.Core.RemotePathMappings;

namespace NzbDrone.Core.Download.Clients.Cloud
{
    public class CloudTorrent : TorrentClientBase<CloudTorrentSettings>
    {
        public override string Name => "Cloud Torrent";

        public CloudTorrent(
            ITorrentFileInfoReader torrentFileInfoReader,
            IHttpClient httpClient,
            IConfigService configService,
            INamingConfigService namingConfigService,
            IDiskProvider diskProvider,
            IRemotePathMappingService remotePathMappingService,
            Logger logger)
            : base(torrentFileInfoReader, httpClient, configService, namingConfigService, diskProvider, remotePathMappingService, logger)
        {
        }

        public override IEnumerable<DownloadClientItem> GetItems()
        {
            throw new NotImplementedException();
        }

        public override void RemoveItem(string downloadId, bool deleteData)
        {
            throw new NotImplementedException();
        }

        public override DownloadClientInfo GetStatus()
        {
            throw new NotImplementedException();
        }

        protected override void Test(List<ValidationFailure> failures)
        {
            throw new NotImplementedException();
        }

        protected override string AddFromMagnetLink(RemoteMovie remoteMovie, string hash, string magnetLink)
        {
            throw new NotImplementedException();
        }

        protected override string AddFromTorrentFile(RemoteMovie remoteMovie, string hash, string filename, byte[] fileContent)
        {
            throw new NotImplementedException();
        }
    }
}
