Enterprise-Mode
===============

Brian Duncan 7/22/14
Software I wrote a while ago, figured I'd upload it to github.

==============
Enterprise Mode


Internet Explorer Enterprise Mode (EM) is Microsoft's implementation of a full IE8-like browser environment into IE11.

This was to benefit organizations (Enterprises) that still depend on outdated webapps. Because of it's implications (probably, anyway),
Microsoft has made EM only manageable by sys-admins (and rightfully so). That is to say, the average user
and, possibly web-developer, may not be able to figure out how to permanently set a website to open in EM.

This tool will do that for you.

==============

(This tool is the equivilent of doing the following process:)
HOW TO ENABLE ENTERPRISE MODE
1) Download Microsoft Enterpise Mode site list creator (google it)
2) Use it to add a site, save to xml
3) Use gpedit.msc to Enable Enterprise Mode (google it)
4) Add the location of the xml from step 2) into the value for step 3)
5) Redo step 2 or 3 or 4 if you need to make specific changes

HOW THIS TOOL BYPASSES THAT
--Gpedit simply sets a reg key, so this program does this for you
--Sitelist creator generates xml in a certain format, so this program replicates that and does it for you
--Sitelist xml saved to app_data roaming
--To change site, simply disable, open IE so it can detect the disable, add new site, close/reopen IE
