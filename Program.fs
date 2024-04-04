// For more information see https://aka.ms/fsharp-console-apps
printfn "Bipana Jirel"

// Define the discriminated union for Genre
type Genre =
    | Horror
    | Drama
    | Thriller
    | Comedy
    | Fantasy
    | Sport

// Define the record type for Director
type Director = {
    Name: string
    Movies: int
}

// Define the record type for Movie
type Movie = {
    Name: string
    RunLength: int  // in minutes
    Genre: Genre
    Director: Director
    IMDBRating: float
}

// Create movie instances
let movies = [
    { Name = "CODA"; RunLength = 111; Genre = Drama; Director = { Name = "Sian Heder"; Movies = 9 }; IMDBRating = 8.1 }
    { Name = "Belfast"; RunLength = 98; Genre = Comedy; Director = { Name = "Kenneth Branagh"; Movies = 23 }; IMDBRating = 7.3 }
    { Name = "Don’t Look Up"; RunLength = 138; Genre = Comedy; Director = { Name = "Adam Mckay"; Movies = 27 }; IMDBRating = 7.2 }
    { Name = "Drive My Car"; RunLength = 179; Genre = Drama; Director = { Name = "Ryusuke Hamaguchi"; Movies = 16 }; IMDBRating = 7.6 }
    { Name = "Dune"; RunLength = 155; Genre = Fantasy; Director = { Name = "Denis Villeneuve"; Movies = 24 }; IMDBRating = 8.1 }
    { Name = "King Richard"; RunLength = 144; Genre = Sport; Director = { Name = "Reinaldo Marcus Green"; Movies = 15 }; IMDBRating = 7.5 }
    { Name = "Licorice Pizza"; RunLength = 133; Genre = Comedy; Director = { Name = "Paul Thomas Aderson"; Movies = 49 }; IMDBRating = 7.4 }
    { Name = "Nightmare Alley"; RunLength = 150; Genre = Thriller; Director = { Name = "Guillermo Del Toro"; Movies = 22 }; IMDBRating = 7.1 }
]

// Printing the list of movies
printfn "List of all Movies:"
List.iter (fun movie -> printfn "%s" movie.Name) movies
printfn ""

// Identify probable Oscar winners
let presumableOscarWinners = List.filter (fun movie -> movie.IMDBRating > 7.4) movies

// Print presumable Oscar winners
printfn "Presumable Oscar Winners:"
List.iter (fun movie -> printfn "%s" movie.Name) presumableOscarWinners
printfn ""

// Convert movie run length to hours
let conToHours (runLength: int) =
    let hours = runLength / 60
    let minutes = runLength % 60
    sprintf "%dh %dmin" hours minutes

// Convert run length for all movies
let RunLengthsconverted = List.map (fun movie -> conToHours movie.RunLength) movies

// Display converted run lengths
printfn "Run Lengths converted:"
List.iter2 (fun movie length -> printfn "%s: %s" movie.Name length) movies RunLengthsconverted
printfn ""