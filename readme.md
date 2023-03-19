# Markdown to Html

This repository contains two "main" projects

* [a lib](/markdown-to-html-lib) for parsing md to html
* [a cli app](/markdown-to-html) for running the lib from the command line

## Links

[repo in github](https://github.com/bobthearsonist/markdown-to-html)

## Overview

I used two libs in the interest of time, both can do the conversions needed, however those features were not leveraged to follow the instructions of the assignment.

* [HTML agility pack](https://html-agility-pack.net/) was used to generate the HTML document
* [markdig](https://github.com/xoofx/markdig) for parsing the markdown document

I chose to focus on testing methodology/documentation rather than regex parsing so to stick to the time limit I "offloaded" those tasks to these two libs.

## Setup

You will need dotnet. you may use your preferred installation method or package manager however this documentation is written using brew.

```bash
brew install dotnet
```

## Development

to run the application 

```bash
 dotnet run --project markdown-to-html/markdown-to-html.csproj
```

to test the application

```bash
dotnet test
```