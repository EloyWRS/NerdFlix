# NerdFlix
ASP.NET 5 Web App MVC that allows user to add information related to a movie. 
It also allows user to pick a movie from a list and load another page with its video movie trailer and the rest of its stored information.

The goal is to create a web page in which the user can:

1 - Create, Read, Update, and Delete a movie in a database; 
2 - Have a page/view displaying the list of movies updated; 
3 - Associate a link to each of the listed movies to a standardized page/view where
the selected movie trailer and its information are displayed.

The main challenge faced with this project was finding out how to display the information of the Awards property of the Movie Class
in a given view since it needs to be represented by a one-to-many relationship (one movie may have many awards). The issue was not related 
to structuring the database, instead I was not being able to access the data contained in the "Movie" property "Awards"(collection) from the "Movie" view. 

After many unsuccessful self-experimenting on my part I decided to go through all the documentation, 
which made me understand how to correctly load the data in the controllers and that I had to create an extra model class called "MovieIndexData"
which stores collections of both Movies and Awards.

In this way, I was able to call this new class as model for any given view and access every property correctly. 

Now I have a fourth goal which is to store a cover image for each movie. 
I also want to note that my main focus on this project is the backend and getting the app to work just as I want it.


