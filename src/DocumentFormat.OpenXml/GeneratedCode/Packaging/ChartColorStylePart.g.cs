﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;

namespace DocumentFormat.OpenXml.Packaging
{
    /// <summary>
    /// Defines the ChartColorStylePart
    /// </summary>
    [OfficeAvailability(FileFormatVersions.Office2013)]
    [ContentType(ContentTypeConstant)]
    public partial class ChartColorStylePart : OpenXmlPart, IFixedContentTypePart
    {
        internal const string ContentTypeConstant = "application/vnd.ms-office.chartcolorstyle+xml";
        internal const string RelationshipTypeConstant = "http://schemas.microsoft.com/office/2011/relationships/chartColorStyle";

        /// <summary>
        /// Creates an instance of the ChartColorStylePart OpenXmlType
        /// </summary>
        internal protected ChartColorStylePart()
        {
        }

        /// <inheritdoc/>
        public sealed override string ContentType => ContentTypeConstant;

        /// <inheritdoc/>
        internal sealed override bool IsContentTypeFixed => true;

        /// <inheritdoc/>
        public sealed override string RelationshipType => RelationshipTypeConstant;

        /// <inheritdoc/>
        internal sealed override string TargetName => "colors";

        /// <inheritdoc/>
        internal sealed override string TargetPath => ".";

        internal override bool IsInVersion(FileFormatVersions version)
        {
            return version.AtLeast(FileFormatVersions.Office2013);
        }
    }
}
