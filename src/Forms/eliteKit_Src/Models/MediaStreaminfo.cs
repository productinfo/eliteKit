﻿namespace eliteKit.Models
{
    internal abstract class MediaStreamInfo
    {
        /// <summary>
        /// Unique tag that identifies the properties of the associated stream.
        /// </summary>
        public int Itag { get; }

        /// <summary>
        /// URL of the endpoint that serves the associated stream.
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Container type of the associated stream.
        /// </summary>
        public Container Container { get; }

        /// <summary>
        /// Content length (bytes) of the associated stream.
        /// </summary>
        public long Size { get; }

        /// <summary>
        /// Initializes an instance of <see cref="MediaStreamInfo"/>.
        /// </summary>
        protected MediaStreamInfo(int itag, string url, Container container, long size)
        {
            Itag = itag;
            Url = url;
            Container = container;
            Size = size;
        }

        /// <inheritdoc />
        public override string ToString() => $"{Itag} ({Container})";
    }
}
