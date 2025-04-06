# Model-View-Controller applications (MVC Apps)
- Similar to Razor Apps
- Use Razor Syntax for views
## Controllers
- Controllers receive HTTP requests and process with actions
## Models
- Models contain business logic. These should not referece controllers or views, for unit testability.
- May be referred to as ViewModel or used with a ViewModel class
## views
- Selected by the controller
- Used to contain the logic to present data as views
- Uses razor syntax