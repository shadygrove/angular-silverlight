# angular-silverlight
Sample app showing how Silverlight and Angular can interact via Script Objects

About This Repo
=================
I have been trying to figure out the best way to handle the javascript callbacks within an Angular application, and have created a working sample.  

Proposed Solution
-----------
Here is an example of calling a script object without using Init Params…
ScriptObject myScriptObject = (ScriptObject)HtmlPage.Window.Invoke("myJSObject");
myScriptObject.Invoke("myMethod");
 
myJSObject is a Javascript object that we would create in the html/js UI.
 
Here is how it would look with Init Params
ScriptObject myScriptObject = (ScriptObject)HtmlPage.Window.Invoke(InitParams[‘jsObjType’]);
myScriptObject.Invoke InitParams[‘jsObjFunctionName’]);
 
This approach will give the most flexibility and best support for Angular.

### Running web app on non-Windows machine with Node/NPM
•	git clone
•	cd SilverlightWithAngular.Web  (separate directory b/c other directory contains Silverlight source)
•	npm install   (there is one package, npm-serve that will launch a web server for static files)
•	serve
•	http://localhost:8080/
Note: I did not use Silverlight.js in the example, but using this approach should give us the flexibility to do that in our Angular directives and controllers since we can inject the script object into Angular.
 
There are still some things to figure out, but this should provide enough for Zeeshan and Randy to implement the callback support in the Silverlight apps.
 
Hope this helps.
