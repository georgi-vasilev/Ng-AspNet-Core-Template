# Ng-AspNet-Core-Template
How to install it?
Open Powershell and use the following commands\
  dotnet new --install aspnet-core-ng::1.0.1\
  dotnet new aspnet-core-ng\
  (Keep in mind that the Solution name will be the same as the parent folder e.g. if you run the cli commands in folder Test, then the solution and all projects will be Test, Test.Web etc.)


The template is based on Nikolay Kostov's template, however, it was modified to be Single-page application (SPA) with Angular 12.
The BaseService, BaseDeletableService and some of the mapping extensions are created and kindly provided by my dear friend Atanas Vasilev.
There is also JWT Authentication implemented as well as some extension methods for the user.
I've used some extension methods in infrastructure project that I've seen from Ivaylo Kenov's Catstagram app.

This template gives you implementation for JWT Authentication in the front-end as well in the back-end and it is ready to use.
The front-end uses ng-bootstrap and toasts that are already added. There is only user module and login/register components.
Also there is BaseService in the front-end as well.
Please if you have any other ideas for features you'd like to add feel free to make a PR and whenever I have free time I will review it and approve it.
If you liked it leave a star.

Nikolay Kostov's Github: https://github.com/nikolayIT/ \
Atanas Vasilev's Github: https://github.com/NaskoVasilev/ \
Ivaylo Kenov's Github: https://github.com/ivaylokenov/ 

Project skeleton that I used: https://github.com/NikolayIT/ASP.NET-Core-Template
