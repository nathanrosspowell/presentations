Presentations
=============

This is a source repository of slide show presentations.


How to View
===========

If you wish to view the slideshows, follow [this](http://nathanrosspowell.github.io/presentations) link.
 

How to contibrute
=================

If you are familiar with GitHub then issue a pull request.
If you are an end user of this conetent then I wil be happy to give you the power to directly edit the source documents in the web browser. 

How to Build the Slideshows on your Computer
============================================

* Install [GitHub](https://help.github.com/articles/set-up-git/) ( or [git](http://git-scm.com/book/en/v2/Getting-Started-Installing-Git) ) and clone the repository.
    * Use the "Clone In Desktop" button form [this](https://github.com/nathanrosspowell/presentations) page
    * -OR-
    * use `git clone git@github.com:nathanrosspowell/presentations.git` on the command line
* Install [node.js](http://nodejs.org/download/) in the correct way for your platform
* Install the [Grunt](http://gruntjs.com) command line interface globally
    * `npm install grunt-cli -g`
* Install all of the project dependencies 
    * `npm install`
* Run the default grunt task to generate the `build` folder
    * `grunt`
* Open one of the slideshows from the build folder
    * Double click the file `\presentations\build\beginner_guides\programmer_talk\index.html`
    * The content of this is sildeshow is from `\presentations\src\markdown\beginner_guides\programmer_talk.md`
* Run the Grunt task again if you make changes to the source `.md` mardown file
    * `grunt`


