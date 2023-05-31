#pragma checksum "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37d12b143a49e1f60b684f899ac33403873dd897"
// <auto-generated/>
#pragma warning disable 1591
namespace SEP6.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using SEP6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using SEP6.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
using SEP6.Temporary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
using Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
using SEP6.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/MovieList")]
    public partial class MovieList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "img");
            __builder.AddAttribute(3, "src", "images/HallOfFame.jpg");
            __builder.AddAttribute(4, "alt", "Hall of Fame");
            __builder.AddAttribute(5, "class", "logo");
            __builder.AddAttribute(6, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
                                                                               OpenHallOfFame

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.AddMarkupContent(8, "<h1 class=\"title\">Explore all movies</h1>\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "bar");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "search-bar");
#nullable restore
#line 19 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
             if (_searchMode)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "text");
            __builder.AddAttribute(15, "placeholder", "Search by title");
            __builder.AddAttribute(16, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
                                          _searchQuery

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _searchQuery = __value, _searchQuery));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "class", "custom-button");
            __builder.AddAttribute(21, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
                                                        SearchMovies

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "class", "close-button");
            __builder.AddAttribute(26, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
                                                       CloseSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(27, "<span>&times;</span>");
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", "custom-button");
            __builder.AddAttribute(30, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
                                                        ToggleSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Search Movies");
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        \r\n        ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "dropdown");
            __builder.AddMarkupContent(35, "<input type=\"checkbox\" id=\"menu-toggle\" class=\"dropdown-toggle\">\r\n            ");
            __builder.AddMarkupContent(36, "<label for=\"menu-toggle\" class=\"dropdown-label\">&#9776; Menu</label>\r\n            ");
            __builder.OpenElement(37, "ul");
            __builder.AddAttribute(38, "class", "dropdown-menu");
            __builder.OpenElement(39, "li");
            __builder.OpenElement(40, "a");
            __builder.AddAttribute(41, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
                                 OpenFavouriteMovies

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(42, "Favourite lists");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "li");
            __builder.OpenElement(45, "a");
            __builder.AddAttribute(46, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
                                 OpenPublicLists

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(47, "View other favourite lists");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n        \r\n        ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "filter-bar");
            __builder.AddMarkupContent(51, "<label for=\"filter-decade\">Display all the most popular movies or filter them by decade:</label>\r\n            ");
            __builder.OpenElement(52, "select");
            __builder.AddAttribute(53, "id", "filter-decade");
            __builder.AddAttribute(54, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
                                                  FilterByDecade

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(55, "option");
            __builder.AddAttribute(56, "value", "all");
            __builder.AddContent(57, "All");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "option");
            __builder.AddAttribute(60, "value", "2020s");
            __builder.AddContent(61, "2020s");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.OpenElement(63, "option");
            __builder.AddAttribute(64, "value", "2010s");
            __builder.AddContent(65, "2010s");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.OpenElement(67, "option");
            __builder.AddAttribute(68, "value", "2000s");
            __builder.AddContent(69, "2000s");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.OpenElement(71, "option");
            __builder.AddAttribute(72, "value", "1990s");
            __builder.AddContent(73, "1990s");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                ");
            __builder.OpenElement(75, "option");
            __builder.AddAttribute(76, "value", "1980s");
            __builder.AddContent(77, "1980s");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                ");
            __builder.OpenElement(79, "option");
            __builder.AddAttribute(80, "value", "1970s");
            __builder.AddContent(81, "1970s");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                ");
            __builder.OpenElement(83, "option");
            __builder.AddAttribute(84, "value", "1960s");
            __builder.AddContent(85, "1960s");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                ");
            __builder.OpenElement(87, "option");
            __builder.AddAttribute(88, "value", "1950s");
            __builder.AddContent(89, "1950s");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n\r\n    ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "movie-list");
#nullable restore
#line 57 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
         foreach (var movie in _movies)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
             if (movie != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "movie-card");
            __builder.AddAttribute(95, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
                                                  ()=>OpenMovieOverview(movie)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "movie-poster-container");
#nullable restore
#line 63 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
                         if (!string.IsNullOrEmpty(movie.PosterPath))
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(98, "img");
            __builder.AddAttribute(99, "class", "movie-poster");
            __builder.AddAttribute(100, "src", "https://image.tmdb.org/t/p/w500/" + (
#nullable restore
#line 65 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
                                                                                            movie.PosterPath

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(101, "alt", 
#nullable restore
#line 65 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
                                                                                                                    movie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 66 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(102, "<img class=\"fallback-poster\" src=\"fallback-image.jpg\" alt=\"No Poster Available\">");
#nullable restore
#line 70 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                    ");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "movie-details");
            __builder.OpenElement(106, "h4");
            __builder.AddAttribute(107, "class", "movie-title");
#nullable restore
#line 73 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
__builder.AddContent(108, movie.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                        ");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "movie-info");
            __builder.OpenElement(112, "p");
            __builder.AddAttribute(113, "class", "movie-release-date");
            __builder.AddMarkupContent(114, "<strong><em>Release Date:</em></strong> ");
            __builder.OpenElement(115, "em");
#nullable restore
#line 75 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
__builder.AddContent(116, movie.ReleaseDate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n                            ");
            __builder.OpenElement(118, "p");
            __builder.AddAttribute(119, "class", "movie-vote-average");
            __builder.AddMarkupContent(120, "<strong><em>Vote Average:</em></strong> ");
            __builder.OpenElement(121, "em");
#nullable restore
#line 76 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
__builder.AddContent(122, movie.VoteAverage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n                            ");
            __builder.OpenElement(124, "p");
            __builder.AddAttribute(125, "class", "movie-vote-count");
            __builder.AddMarkupContent(126, "<strong><em>Vote Count:</em></strong> ");
            __builder.OpenElement(127, "em");
#nullable restore
#line 77 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
__builder.AddContent(128, movie.VoteCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                        ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "add-to-favorite-container");
            __builder.OpenElement(132, "button");
            __builder.AddAttribute(133, "class", "add-to-favorite-button");
            __builder.AddAttribute(134, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
                                                                             ()=>AddToFavorites(movie)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(135, "Add to Favorite");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 84 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 87 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
     if (_movies.Count > 10)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(136, "div");
            __builder.AddAttribute(137, "class", "pagination");
#nullable restore
#line 90 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
             if (_currentPage != 1)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(138, "button");
            __builder.AddAttribute(139, "class", "page-navigation");
            __builder.AddAttribute(140, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 92 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
                                                          () => ChangePage(-1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(141, "Previous");
            __builder.CloseElement();
#nullable restore
#line 93 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(142, "span");
            __builder.AddAttribute(143, "class", "current-page");
            __builder.AddContent(144, "Page ");
#nullable restore
#line 94 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
__builder.AddContent(145, _currentPage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n            ");
            __builder.OpenElement(147, "button");
            __builder.AddAttribute(148, "class", "page-navigation");
            __builder.AddAttribute(149, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 95 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
                                                      () => ChangePage(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(150, "Next");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 97 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n\r\n");
            __builder.AddMarkupContent(152, "<style>\r\n    html, body {\r\n        height: 100%;\r\n        margin: 0;\r\n        padding: 0;\r\n    }\r\n\r\n    body {\r\n        background-image: url(\'images/Background.jpg\');\r\n        background-size: cover;\r\n        background-position: center;\r\n        background-repeat: no-repeat;\r\n        background-attachment: fixed;\r\n        padding: 20px;\r\n    }\r\n\r\n    .container {\r\n        display: flex;\r\n        flex-wrap: wrap;\r\n        justify-content: center;\r\n        align-items: center;\r\n        min-height: 100vh;\r\n    }\r\n\r\n    .title {\r\n        width: 100%;\r\n        text-align: center;\r\n        color: white;\r\n        font-size: 35px;\r\n        font-family: Amiri,serif;\r\n        margin: 30px;\r\n    }\r\n    \r\n    .logo {\r\n        width: 400px;\r\n        height: auto;\r\n        margin-bottom: 10px;\r\n        cursor: pointer;\r\n    }\r\n\r\n    .movie-list {\r\n        display: flex;\r\n        flex-wrap: wrap;\r\n        justify-content: center;\r\n        align-items: center;\r\n        margin: 0;\r\n        padding: 0;\r\n    }\r\n\r\n    .movie-card {\r\n        width: 300px;\r\n        margin: 20px;\r\n        padding: 10px;\r\n        background-color: transparent;\r\n        border-radius: 5px;\r\n        box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);\r\n        cursor:pointer;\r\n    }\r\n\r\n    .movie-poster-container {\r\n        height: 400px;\r\n        display: flex;\r\n        justify-content: center;\r\n        align-items: center;\r\n    }\r\n\r\n    .movie-poster,\r\n    .fallback-poster {\r\n        max-width: 100%;\r\n        max-height: 100%;\r\n    }\r\n\r\n    .fallback-poster {\r\n        object-fit: contain;\r\n        background-color: #ddd;\r\n        padding: 10px;\r\n    }\r\n\r\n    .movie-details {\r\n        padding: 10px;\r\n        height: 100%;\r\n        display: flex;\r\n        flex-direction: column;\r\n        justify-content: space-between;\r\n    }\r\n\r\n    .movie-title {\r\n        font-size: 18px;\r\n        font-weight: bold;\r\n        margin-bottom: 10px;\r\n        word-break: break-word;\r\n        text-align: center;\r\n        color: white;\r\n    }\r\n\r\n    .movie-info {\r\n        flex-grow: 1;\r\n    }\r\n\r\n    .movie-release-date,\r\n    .movie-vote-average,\r\n    .movie-vote-count {\r\n        margin-bottom: 5px;\r\n        color: white;\r\n    }\r\n\r\n    .pagination {\r\n        display: flex;\r\n        justify-content: center;\r\n        margin-top: 20px;\r\n    }\r\n\r\n    .page-navigation {\r\n        padding: 10px 20px;\r\n        margin: 0 5px;\r\n        background-color: #ff6b6b;\r\n        color: #fff;\r\n        border: none;\r\n        border-radius: 3px;\r\n        cursor: pointer;\r\n    }\r\n\r\n    .current-page {\r\n        font-weight: bold;\r\n        color: white;\r\n    }\r\n\r\n    .search-bar {\r\n        display: flex;\r\n        align-items: center;\r\n        justify-content: center;\r\n        margin-bottom: 20px;\r\n    }\r\n\r\n    .search-bar input {\r\n        padding: 5px;\r\n        font-size: 14px;\r\n        border: 1px solid #ccc;\r\n        border-radius: 3px;\r\n    }\r\n\r\n    .search-bar button {\r\n        padding: 5px 10px;\r\n        background-color: #ff6b6b;\r\n        color: #fff;\r\n        border: none;\r\n        border-radius: 3px;\r\n        cursor: pointer;\r\n        margin-left: 10px;\r\n    }\r\n\r\n    .close-button {\r\n        padding: 5px;\r\n        background-color: #dc3545;\r\n        color: #fff;\r\n        border: none;\r\n        border-radius: 50%;\r\n        cursor: pointer;\r\n        margin-left: 10px;\r\n    }\r\n\r\n    .close-button span {\r\n        font-size: 12px;\r\n        line-height: 1;\r\n    }\r\n\r\n    .filter-bar {\r\n        display: flex;\r\n        align-items: center;\r\n        justify-content: center;\r\n        margin-bottom: 20px;\r\n    }\r\n\r\n    .filter-bar label {\r\n        margin-right: 10px;\r\n        background-color: #f5f5f5;\r\n        border-radius: 3px;\r\n        border: white 1px solid;\r\n        padding: 4px;\r\n        color: black;\r\n    }\r\n\r\n    .filter-bar select {\r\n        padding: 5px;\r\n        font-size: 14px;\r\n        border: 1px solid #ccc;\r\n        border-radius: 3px;\r\n    }\r\n    \r\n   .dropdown {\r\n           position: relative;\r\n           display: flex;\r\n           align-items: center;\r\n           margin-bottom: 20px;\r\n           justify-content: center;\r\n       }\r\n   \r\n       .dropdown-toggle {\r\n           display: none;\r\n       }\r\n   \r\n       .dropdown-label {\r\n           display: block;\r\n           padding: 10px;\r\n           background-color: #ff6b6b;\r\n           color: white;\r\n           cursor: pointer;\r\n           border-radius: 3px;\r\n           border: 1px solid #ccc;\r\n       }\r\n   \r\n       .dropdown-toggle:checked + .dropdown-label {\r\n           background-color: darkorange;\r\n       }\r\n   \r\n       .dropdown-menu {\r\n           position: absolute;\r\n           top: 100%;\r\n           left: 0;\r\n           padding: 0;\r\n           list-style-type: none;\r\n           background-color: #ff6b6b;\r\n           color: white;\r\n           box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);\r\n           display: none;\r\n           margin-top: 3px;\r\n           margin-left: 100px;\r\n           margin-right: 1000px;\r\n       }\r\n   \r\n       .dropdown-toggle:checked + .dropdown-label + .dropdown-menu {\r\n           display: block;\r\n       }\r\n   \r\n   .dropdown-menu li {\r\n       padding: 10px;\r\n       width: 200px;\r\n   }\r\n   \r\n   .dropdown-menu li a {\r\n       color: white;\r\n       text-decoration: none;\r\n   }\r\n   \r\n   .dropdown-menu li a:hover {\r\n       background-color: darkorange;\r\n   }\r\n   \r\n   .add-to-favorite-container {\r\n       display: flex;\r\n       justify-content: center;\r\n       align-items: center;\r\n       margin-top: 10px;\r\n   }\r\n   \r\n   .add-to-favorite-button {\r\n       padding: 5px 10px;\r\n       background-color: #ff6b6b;\r\n       color: #fff;\r\n       border: none;\r\n       border-radius: 3px;\r\n       cursor: pointer;\r\n   } \r\n   \r\n</style>\r\n    \r\n}");
        }
        #pragma warning restore 1998
#nullable restore
#line 366 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\MovieList.razor"
       
    private List<MovieDetails> _movies = new List<MovieDetails>();
    private int _currentPage = 1;
    private string _searchQuery = string.Empty;
    private bool _searchMode = false;

    protected override async Task OnInitializedAsync()
    {
        if (DataSession.User == null)
            Navigation.NavigateTo("LogIn");
        await LoadMovies();
    }

    private async Task LoadMovies()
    {

        if (string.IsNullOrEmpty(_searchQuery))
        {
            _movies = await _tmdbApiClient.GetMovies(_currentPage);
        }
        else
        {
            List<MovieDetails> moviesByTitle = new List<MovieDetails>();
            moviesByTitle.Add(await _tmdbApiClient.GetMovieByTitle(_searchQuery));
            _movies = moviesByTitle;
        }
    }

    private async Task ChangePage(int offset)
    {
        _currentPage += offset;
        if (_currentPage < 1)
            _currentPage = 1;

        await LoadMovies();
    }

    private async Task SearchMovies()
    {
        _currentPage = 1;
        await LoadMovies();
        _searchMode = true;
    }

    private async void CloseSearch()
    {
        _searchMode = false;
        _searchQuery = string.Empty;
        _currentPage = 1;
        await LoadMovies();
        StateHasChanged();
    }

    private async Task FilterByDecade(ChangeEventArgs e)
    {
        if (e.Value != null)
        {
            string decade = e.Value.ToString();
            if (decade.Equals("all"))
                _movies = await _tmdbApiClient.GetPopularMovies();
            else
            {
                _movies = await _tmdbApiClient.Get10MostPopularMoviesByDecade(int.Parse(decade.Replace("s", "")));
            }
        }
        StateHasChanged();
    }

    private async Task ViewMostPopularMovies()
    {
        _movies = await _tmdbApiClient.GetPopularMovies();
        StateHasChanged();
    }

    private void ToggleSearch()
    {
        _searchMode = true;
    }
    
    private void OpenHallOfFame()
    {
        Navigation.NavigateTo("HallOfFame");
    }

    private void OpenMovieOverview(MovieDetails movie)
    {
        DataSession.Instance.MovieDetails = movie;
        Navigation.NavigateTo("/MovieOverview");
    }
    
    private async Task AddToFavorites(MovieDetails movie)
    {
        await DatabaseRetriever.AddMovie(new Movie { ID = 0,MovieID = Convert.ToInt32(movie.Id),MovieListID = DataSession.User.MovieListID});
    }

    private void OpenFavouriteMovies()
    {
        Navigation.NavigateTo("FavouriteList");
    }
    
    private void OpenPublicLists()
    {
        Navigation.NavigateTo("PublicLists");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataSession DataSession { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDatabaseRetriever DatabaseRetriever { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IApiRetriever _tmdbApiClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591