﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebApiContrib.Formatting.Xlsx;

namespace WebApiCSVExportFromElasticsearch.Models
{
	public class Person
	{
		[Key]
		public int BusinessEntityID { get; set; }

		[Required]
		[StringLength(2)]
		public string PersonType { get; set; }

		public bool NameStyle { get; set; }

		[StringLength(8)]
		public string Title { get; set; }

		[Required]
		[StringLength(50)]
		public string FirstName { get; set; }

		[StringLength(50)]
		public string MiddleName { get; set; }

		[Required]
		[StringLength(50)]
		public string LastName { get; set; }

		[StringLength(10)]
		public string Suffix { get; set; }

		public int EmailPromotion { get; set; }

		[Column(TypeName = "xml")]
		public string AdditionalContactInfo { get; set; }

		[Column(TypeName = "xml")]
		public string Demographics { get; set; }

		public Guid rowguid { get; set; }

		[DisplayFormat(DataFormatString = "{0:D}")]
		[ExcelColumn(UseDisplayFormatString = true)]
		public DateTime ModifiedDate { get; set; }

		public bool Deleted { get; set; }

	}
}