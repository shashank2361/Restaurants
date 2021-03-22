$MigrationsPath = Join-Path -Path $(Get-Item -Path $PSCommandPath).Directory -ChildPath "\Migrations"

Get-ChildItem $MigrationsPath -Recurse | Remove-Item

dotnet ef migrations add CreateSchema -p RestaurantListings -o $MigrationsPath
dotnet ef database drop -p RestaurantListings -f
dotnet ef database update -p RestaurantListings
