﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Html2Amp.IntegrationTests
{
	[TestClass]
	public class HtmlToAmpConverting
	{
		[TestMethod]
		public void ConvertSimpleImageElementToAmp()
		{
			// Arrange
			string htmlToConvert = "<img src=\"test-image.png\" width=\"100\" height=\"100\" />";
			var htmlToAmpConverter = new HtmlToAmpConverter();

			// Act
			string ampHtml = htmlToAmpConverter.ConvertFromHtml(htmlToConvert);

			// Assert
			Assert.AreEqual("<amp-img src=\"test-image.png\" width=\"100\" height=\"100\" layout=\"responsive\"></amp-img>", ampHtml);
		}
	}
}