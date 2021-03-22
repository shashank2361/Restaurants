# BMA Dev Test

## RestaurantListings

RestaurantListings is simple restaurant viewer app. The functionality is quite simple: Fetch the list of available restaurants from the API and display them to the user. The user should be able to search the restaurants with a variety of filters. A basic boilerplate has been provided for the app which consists of two main components:

- RestaurantListings - The AspNetCore backend
- RestaurantListings.UI - The React frontend

The application can be started by running the main **RestaurantListings**

```bash
dotnet run -p ./RestaurantListings
```

This will start both the API and React frontend.

## Requirements

The initial implementation has been already been completed; but it's ugly, buggy and uses a variety of bad practices. Refactor the app to meet the following requirements:

- The user is presented with a list of restaurants:

  - The list should show the image, title, description, and other basic info
  - The list should use semantically sound HTML and modern CSS practices
  - Make use of your choice of styling systems (CSS-in-JS, SASS, CSS, etc)
  - **BONUS**: Make the layout responsive
  - **BONUS**: Lazy load the restaurants page

(**Note:** approximate time allocation to do the work is included in brackets)

- Make the restaurant list more attractive for the end user _(15 to 20 Minutes)_

- The user should be able to filter restaurants efficiently and consistently via a number of options:

  - Through the tags:
    - which should be displayed alphabetically _(5 Minutes)_
    - Multiple tags can be selected at a time _(10 Minutes)_
    - No duplicate tags should be shown _(5 Minutes)_
    - Correcting functional erorrs in this section of work _(10 Minutes)_
  - Through the family friendly and vegan options, which should check the relevant flags on the restaurant _(10 Minutes)_

- Add basic rating functionality to the API and frontend:

  - Only signed in users should be able to rate a restaurant _(Front-end: 30 Minutes) (Backend: 30 Minutes)_
    - The rating should be restricted between 1 and 5
  - Recalculate the average restaurant rating when a new rating is applied _(10 Minutes)_
  - Display the average restaurant rating on the restaurant list _(Front-end: 5 minutes) (Back-end: 5 Minutes)_
  - Only one rating per user per restaurant should be allowed, but they are allowed to change their rating _(5 Minutes)_
