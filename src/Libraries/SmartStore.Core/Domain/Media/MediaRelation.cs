﻿using System;
using System.Runtime.Serialization;
using SmartStore.Utilities;

namespace SmartStore.Core.Domain.Media
{
    [DataContract]
    public partial class MediaRelation : BaseEntity, IEquatable<MediaRelation>
    {
        private int _mediaFileId;
        private int _entityId;
        private string _entityName;
        private int? _hashCode;

        /// <summary>
        /// Gets or sets the media file identifier.
        /// </summary>
        [DataMember]
        public int MediaFileId
        {
            get => _mediaFileId;
            set
            {
                _mediaFileId = value;
                _hashCode = null;
            }
        }

        /// <summary>
        /// Gets or sets the media file.
        /// </summary>
        public virtual MediaFile MediaFile { get; set; }

        /// <summary>
        /// Gets or sets the origin album system name.
        /// </summary>
        public string Album { get; set; }

        /// <summary>
        /// Gets or sets the related entity identifier.
        /// </summary>
        [DataMember]
        public int EntityId
        {
            get => _entityId;
            set
            {
                _entityId = value;
                _hashCode = null;
            }
        }

        /// <summary>
        /// Gets or sets the related entity set name.
        /// </summary>
        [DataMember]
        public string EntityName
        {
            get => _entityName;
            set
            {
                _entityName = value;
                _hashCode = null;
            }
        }

        public int HashCode
        {
            get => GetHashCode();
            set
            {
                // Setter for EF
                _hashCode = value;
            }
        }

        protected override bool Equals(BaseEntity other)
        {
            return ((IEquatable<MediaRelation>)this).Equals(other as MediaRelation);
        }

        bool IEquatable<MediaRelation>.Equals(MediaRelation other)
        {
            if (other == null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return this.MediaFileId == other.MediaFileId
                && this.EntityId == other.EntityId
                && this.EntityName.Equals(other.EntityName, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            if (_hashCode == null)
            {
                var combiner = HashCodeCombiner
                    .Start()
                    .Add(GetUnproxiedType().GetHashCode())
                    .Add(this.MediaFileId)
                    .Add(this.EntityId)
                    .Add(this.EntityName);

                _hashCode = combiner.CombinedHash;
            }

            return _hashCode.Value;
        }

        public override string ToString()
        {
            return $"IndexBacklog (EntityName: {EntityName}, EntityId: {EntityId}, MediaFileId: {MediaFileId})";
        }
    }
}