2024-05-23
Matthew Gabrielle
1335
Part 4 - add a model to an ASP.NET Core MVC app

1340
In Complete the Add MVC Controller with views, using Entity Framework dialog:
I received an error, and selected Add a second time to try again.
I tried 4 times, and kept receiving the error "there was an error running the selected code generator failed to build the project fix the build errors and try again"

I ran Build>Build Solution and traced the error to a missing } in HelloWorldController.cs

1345
I was successfully able to add the controller.

1355
I ran the app and selected the Movie App link as instructed. However, the instructions did not tell me what I should expect to see after I selected Movie App, which was unhelpful.

1405
Migrated 20240523175417_InitialCreate

1420
Examined the generated Details method in the Controllers/MoviesController.cs file.

1430
Examined the contents of the Views/Movies/Details.cshtml file.

1435
Examined the Index.cshtml view and the Index method in the Movies controller. 

1440 
Began part 5, work with a database in an ASP.NET Core MVC app.

1442 
SQL Server Express LocalDB: examined database.

1445 
When using SQL Server Object Explorer, it took about 30 seconds for dbo.Movie to populate.

1505
Seeded the database. Replaced movies with my own.

1506
Added the seed initializer.

1525
Demonstrated movie database to instructor. The database itself had 'null' entries, and I did not have a space in ReleaseDate.

1528 
Began part 6, controller methods and views in ASP.NET Core.

1536
Opened the Models/Movie.cs file and added the highlighted lines.

1543
Ran the application and navigated to the /Movies URL. Clicked an Edit link. In Firefox, viewed the source for the page.

1546
Began part 7, add search to an ASP.NET Core MVC app.

1550 
Updated the Index method found inside Controllers/MoviesController.cs with the provided code.

1402
Tested the updates I made. It was successful.

1405
Added searchString parameter.

1412
Specified the request should be HTTP GET found in the Views/Movies/Index.cshtml file.

1420
Added the MovieGenreViewModel.cs to the Models folder.

1422
Replaced the Index method in MoviesController.cs with the provided code.

1425
Added search by genre to the Index view.

1428
Began part 8, add a new field to an ASP.NET Core MVC app.

1429
Added a Rating property to Models/Movie.cs.

1430
In MoviesController.cs, updated the [Bind] attribute for both the Create and Edit action methods to include the Rating property.

1432
Edited the /Views/Movies/Index.cshtml file and added a Rating field.

2024-05-30
1245
Ran program, did not receive errors, but "Rating" was not available. Inspected MoviesController.cs, and discovered a second "Bind" I needed to add a Rating to.

1253 
Ran program, this time "Rating" was shown, but when I clicked Edit, Rating was not available in the options.

1259 
Discovered an error in Views/Movies/Create.cshtml, where I had made an error in putting "Price" once in place of "Rating"

1340
Made changes to Views/Movies/Edit.cshtml to add Rating fields

1346
Ran program, saw Rating field in Edit. Proceeded to make changes to Views/Movies/Delete.cshtml and Views/Movies/Details.cshtml

1349
Program ran successfully; was able to add, edit, and delete ratings.

1354
Began part 9, add validation to an ASP.NET Core MVC app.

1359
Discovered the instructions on disabling JavaScript in FireFox were depreciated. Looked up current instructions.

1402
Discovered up-to-date instructions at https://www.lifewire.com/disable-javascript-in-firefox-446039

1418
Began part 10, examined the Details and Delete methods of an ASP.NET Core app.

2024-06-06
1415
Completed review of part 10. 

1417
Confirmed that seed data contained 5 new movies. Interestingly after running the first time, it had four movies, including ones I had edited, that were not in the seed data.

I deleted the movies on the web page, and started the movie app again. This time, all 5 correct movies from the seed data were present.