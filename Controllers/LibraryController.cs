
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using MoodRadio.Dtos.LibraryDtos.Requests;
using MoodRadio.Dtos.LibraryDtos.Responses;
using MoodRadio.Services;

namespace MoodRadio.Controllers
{
    [ApiController]
    [EnableCors("CorsPolicy")]
    [Route("library")]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService libraryService;
        private readonly ILogger<LibraryController> logger;
        private readonly IMapper mapper;

        public LibraryController(ILibraryService libraryService, ILogger<LibraryController> logger, IMapper mapper)
        {
            this.libraryService = libraryService;
            this.logger = logger;
            this.mapper = mapper;
        }

        // /artist
        [HttpPost("artist")]
        public async Task<IActionResult> GetArtist([FromBody] ArtistRequestDto request)
        {
            var artistId = request.ArtistId;

            var artist = await this.libraryService.GetArtistById(artistId);
            if (artist == null) return NotFound();

            var artistAlbums = await this.libraryService.GetArtistAlbumsById(artistId);
            if (artistAlbums.Count() <= 0) return NotFound();
            var albums = new List<AlbumDto>();
            foreach (var album in artistAlbums)
            {
                var albumDto = new AlbumDto() {
                    Name = album.Name
                };
                albums.Add(albumDto);
            }

            var songs = await this.libraryService.GetArtistSongsById(artistId);
            if (songs.Count() <= 0) return NotFound();
            var topTen = new List<SongDto>();
            for (int index = 0; index < 10; index++)
            {
                var song = songs.ElementAt(index);
                var songDto = new SongDto()
                {
                    Name = song.Title,
                    Duration = song.Duration
                };
                topTen.Add(songDto);
            }

            var response = new ArtistResponseDto() {
                Name = artist.Name,
                TopTen = topTen,
                Albums = albums
            };

            return Ok(response);
        }
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



