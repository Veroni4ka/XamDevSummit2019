// <auto-generated> - Template:ModelsBackedByDtoInterface, Version:1.1, Id:4d03f2c7-de27-4aae-a267-cad747c9606a
using System;
using System.Collections.Generic;

namespace MSC.ConferenceMate.Model.CM.Interface
{
	public partial interface IBlobFile
	{
		System.Guid BlobFileId { get; }
		int? BlobFileTypeId { get; }
		string BlobUri { get; }
		byte[] Content { get; }
		string CreatedBy { get; }
		System.DateTime CreatedUtcDate { get; }
		int DataVersion { get; }
		string DiscreteMimeType { get; }
		bool IsDeleted { get; }
		string ModifiedBy { get; }
		System.DateTime ModifiedUtcDate { get; }
		string Name { get; }
		System.Guid? ParentBlobFileId { get; }
		bool? RequiresResize { get; }
		bool? ResizeComplete { get; }
		long? SizeInBytes { get; }

		IBlobFileType BlobFileType { get; }
		// Excluding 'UserProfile' per configuration setting.


	}
}
