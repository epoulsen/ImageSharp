﻿// <copyright file="HuffmanTables.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageSharp.Formats.Jpeg.PdfJsPort.Components
{
    /// <summary>
    /// Represents a jpeg file marker
    /// </summary>
    internal struct FileMarker
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileMarker"/> struct.
        /// </summary>
        /// <param name="marker">The marker</param>
        /// <param name="position">The position within the stream</param>
        public FileMarker(ushort marker, long position)
        {
            this.Marker = marker;
            this.Position = position;
            this.Invalid = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileMarker"/> struct.
        /// </summary>
        /// <param name="marker">The marker</param>
        /// <param name="position">The position within the stream</param>
        /// <param name="invalid">Whether the current marker is invalid</param>
        public FileMarker(ushort marker, long position, bool invalid)
        {
            this.Marker = marker;
            this.Position = position;
            this.Invalid = invalid;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the current marker is invalid
        /// </summary>
        public bool Invalid { get; set; }

        /// <summary>
        /// Gets the position of the marker within a stream
        /// </summary>
        public ushort Marker { get; }

        /// <summary>
        /// Gets the position of the marker within a stream
        /// </summary>
        public long Position { get; }

        /// <inheritdoc/>
        public override string ToString()
        {
            return this.Marker.ToString("X");
        }
    }
}