
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
// using MoodRadio.Dtos.LibraryDtos;
// using MoodRadio.Services;

namespace MoodRadio.Controllers
{
    [ApiController]
    [EnableCors("CorsPolicy")]
    [Route("library")]
    public class LibraryController : ControllerBase
    {
        // private readonly ILibraryService libraryService;
        private readonly ILogger<LibraryController> logger;
        private readonly IMapper mapper;

        // public LibraryController(ILibraryService libraryService, ILogger<LibraryController> logger, IMapper mapper)
        public LibraryController(ILogger<LibraryController> logger, IMapper mapper)
        {
            // this.libraryService = libraryService;
            this.logger = logger;
            this.mapper = mapper;
        }

        // /artist
        /*
        request:
            {
                artistId: uuid
            }
        response:
            {
                name: string
                topTen: [
                    {
                        songId: uuid
                        title: string
                        duration: {
                            min: int
                            sec: int
                        }
                    }
                ]
                albums: [
                    {
                        albumId: uuid
                        title: string
                    }
                ]
            }
        */
        // /artist/discography
        /*
        request:
            {
                artistId: string
            }
        response:
            {
                discography: [
                    {
                        albumId: uuid
                        albumName: string
                        songs: [
                            {
                                songId: uuid
                                title: string
                                duration: {
                                    min: int
                                    sec: int
                                }
                            }
                        ]
                    }
                ]
            }
        */
        // /artist/albums
        /*
        request:
            {
                artistId: uuid
                albumIds: [uuid]?
            }
        response:
            {
                albums: [
                    {
                        albumId: uuid
                        albumName: string
                        songs: [
                            {
                                songId: uuid
                                title: string
                                duration: {
                                    min: int
                                    sec: int
                                }
                            }
                        ]
                    }
                ]
            }
        */
        // /artist/songs
        /*
        request:
            {
                artistId: uuid
                songIds: [uuid]?
            }
        response:
            {
                songs: [
                    {
                        songId: uuid
                        title: string
                        albumId: uuid
                        albumName: string
                        duration: {
                            min: int
                            sec: int
                        }
                    }
                ]
            }
        */

        // /album
        /*
        request:
            {
                albumIds: [uuid]?
            }
        response:
            {
                albums: [
                    {
                        artistId: uuid
                        artistName: string
                        albumId: uuid
                        albumName: string
                        songs: [
                            {
                                songId: uuid
                                title: string
                                duration: {
                                    min: int
                                    sec: int
                                }
                            }
                        ]
                    }
                ]
            }
        */
        // /album/songs
        /*
        request:
            {
                albumIds: [uuid]?
            }
        response:
            {
                songs: [
                    {
                        artistId: uuid
                        artistName: string
                        albumId: uuid
                        albumName: string
                        songId: uuid
                        title: string
                        duration: {
                            min: int
                            sec: int
                        }
                    }
                ]
            }
        */

        // /song

        /*
        request:
            {
                songIds: [uuid]?
            }
        response:
            {
                songs: [
                    {
                        artistId: uuid
                        artistName: string
                        albumId: uuid
                        albumName: string
                        songId: uuid
                        title: string
                        duration: {
                            min: int
                            sec: int
                        }
                    }
                ]
            }
        */
    }
}



