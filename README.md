# WIP
**This project is a work in progress (WIP) and not ready for public consumption.**

A backlog of additions, features, and changes are kept in the [issues]( https://github.com/Jerred-S/excelRegexAndUrlRetrieval/issues) list

# Overview
This is an Excel Addin that retrieves text from a URL and can parse it with regular expressions. Two new functions will be added to Excel:
1. regexReplace, which exposes the regular expression replace function of .NET
2. getDataAtUrl, which retrieves a file at a given URL
The two functions together provide a means to retrive and parse out infromation from a web server. See the [Use](#Use) section below for an example.

# Install
You probably shouldn't use this yet until development is further along, but if you're adventerous, find one of the .xll files in [`getDataAtUrl/bin/Release`](getDataAtUrl/bin/Release) and install it per <http://exceldna.codeplex.com/wikipage?title=Installing%20your%20add-in&referringTitle=Documentation>

# Use
Once the addin is installed (or run-once), use the regexReplace and getDataAtUrl functions like any other excel function. Give this a try by entering it into a cell 
```
=regexReplace(getDataAtUrl("https://www.glerl.noaa.gov//metdata/mil/"),"[\u0001-~]*<strong>Air Temperature[\u0001-~]+?>(.+?)&.*<\/td><[\u0001-~]*","$1")
```
and see what the temperature is in Milwaukee.