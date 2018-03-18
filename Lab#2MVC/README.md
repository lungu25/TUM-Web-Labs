# Laboratory Work Nr.2
## Purpose of the laboratory
Get familiar with MVC pattern;
Choose a MVC pattern to build a web application.
## Main requirements
Integrate HTML template from WT_Lab.1 into a web application;
The application should have more that one page(route).
## Notes
Add in README file how to start the application;
No database interaction is needed;
No JS frameworks are allowed.
## Laboratory work implementation
The Model-View-Controller (MVC) architectural pattern separates an application into three main components: the model, the view, and the controller. The MVC framework includes the following components:

Models. Model objects are the parts of the application that implement the logic for the application's data domain.
Views. Views are the components that display the application's user interface.
Controllers. Controllers are the components that handle user interaction, work with the model, and ultimately select a view to render that displays. The controller handles and responds to user input and interaction.
I chose ASP.NET MVC framework for implementing tasks of this laboratory work and the next ones. ASP.NET MVC is basically a web development framework, which combines the features of MVC architecture and the best parts of the existing ASP.NET platform.

In order to implement the required tasks I built my project from the very begining. First of all I set up my enviroment which is Visual Studio. Next step was creating an empty solution after this I added my web project to it.

Routing process was created automatically from the start. Routing means directing an HTTP request to a controller which is also called request handler.

Next step was to create a controller. As I said controller is the first recipient which interacts with incoming HTML request. In my HomeController I have 3 action methods Index, Smartphones and Tablets, their names coincide with my views. Each of them return a view.

Next I created all my views, it was not that hard because I already had them from WT_Lab.1. All I had to do is to structure them. By structuring I mean adding a template called Layout. It was done in order not to repeat the same piece of code for every view. In layout file you may find the bundles I had configured and some partial vies such as: header, navigation and footer. In my case I have footer and because my navigation bar is placed on the top of the page my navigation serves me as a header, that's header's file is also empty.

In order to make everything working I installed some packages such as bootstrap and jquery, their files where added in Content and Scripts folders. I mention these two because I used them in Bundle configuration. I want to mention here that I added bootstrap manually because the version provided by nuget manager was not convenient for me.

In order to start my project you need Visual Studio. Open my project and run it. It is simple!

## Conclusion
In this laboratory work I learned about MVC pattern and how it is used in order to build a web application. I understand how it works and what is the connection between controllers, views and models. The MVC pattern helps us to create applications that separate the different aspects of the application.
