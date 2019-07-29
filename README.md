# phazor.m13.io
A blazor app hosted in an AWS Lambda just to see if I can get this to work.  Not working at the moment.

Things I've tried:
1. Baking this blazor app into a simple Lambda Function from the AWS Toolkit. Hacked at it for a while and got down to a single Func delegate that wouldn't cooperate, or at least, I wasn't sure quite how the signature should be.
2. Attempt #2 - current incarnation - spun up an AWS Serverless App hosting a .Net Core MVC Web Application.  Attempted to overhaul it a little and wedge blazor in instead of the web application.  Made sure to update to the .net 3.0 framework but still no success.  It will run the app now locally but I am almost certain, this is not the way to go about cobbling this together.

Any PR's are graciously accepted and anyone who wants to hack on this is welcome.  I only found 2 other guys on twitter thinking the same thing, https://twitter.com/Pegazux & https://twitter.com/underhillj
