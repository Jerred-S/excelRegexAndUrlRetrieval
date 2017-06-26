# WIP
**This project is a work in progress (WIP) and not ready for public consumption.**

A backlog of additions, features, and changes are kept in the [issues]( https://github.com/Jerred-S/excelRegexAndUrlRetrieval/issues) list

# Overview
This is an Excel Addin that retrieves text from a URL and can parse it with regular expressions. Two new functions will be added to Excel:
1. regexReplace, which exposes the regular expression replace function of .NET
2. getDataAtUrl, which retrieves a file at a given URL
The two functions together provide a means to retrive and parse out infromation from a web server. See the [Use](#Use) section below for an example.

# Install
There are probably other ways to install this, but the following method worked for me:
1. Download getDataAtUrl-AddIn-packed.xll or getDataAtUrl-AddIn64-packed.xll (get the one that corresponds with your version of Excel) from  [`getDataAtUrl/bin/Release`](getDataAtUrl/bin/Release) 
2. In Excel, open `Excel Options`. This can be done by clicking `File` then `Options`
3. Click `Add-ins`
4. Set the `Manage` drop-down to `Excel Add-ins`, then click `Go...`
5. Click `Browse` and using the file navigator, select the .xll that you just retrieved
6. Click `OK`

# Use
Once the addin is installed (or run-once), use the regexReplace and getDataAtUrl functions like any other excel function. Give this a try by entering it into a cell 
```
=regexReplace(getDataAtUrl("https://www.glerl.noaa.gov//metdata/mil/"),"[\u0001-~]*<strong>Air Temperature[\u0001-~]+?>(.+?)&.*<\/td><[\u0001-~]*","$1")
```
and see what the temperature is in Milwaukee.

# Build and development
This section documents how to build and develop for the project

## getDataAtUrl
TBD

## UnitTests
TBD

## Dependencies
TBD
