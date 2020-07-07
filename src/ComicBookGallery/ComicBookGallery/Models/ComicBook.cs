﻿using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

public class ComicBook
{
	public int id {get; set;}
	public string SeriesTitle { get; set; }
	public int IssueNumber { get; set; }
	public string DescriptionHtml { get; set; }
	public Artist Artists { get; set; }
	public bool Favorite { get; set; }

	public string DisplayText 
	{
        get { return SeriesTitle + " #" + IssueNumber.ToString();        }
	}

	//series-title-issuenumber.jpg

	public string CoverImageFileName 
	{
		get { return SeriesTitle.Replace(" ","-").ToLower()
				+ "-" + IssueNumber + ".jpg"; }
	}
}
