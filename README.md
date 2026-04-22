# Astrolune.UI

Frontend bridge library for Astrolune Desktop. Embeds React UI as resources in DLL.

## Structure

```
Astrolune.UI/
├── client-ui/              # React applications
│   ├── app/               # Main application
│   └── splash/            # Splash screen
├── Resources/             # Built assets (embedded in DLL)
│   ├── app/
│   └── splash/
├── FrontendResourceProvider.cs
└── Astrolune.UI.csproj
```

## Building

```bash
# Build frontend
cd client-ui/app
npm install
npm run build

cd ../splash
npm install
npm run build

# Copy to Resources
cd ../..
mkdir -p Resources/app Resources/splash
cp -r client-ui/app/dist/* Resources/app/
cp -r client-ui/splash/dist/* Resources/splash/

# Build C# project (embeds Resources into DLL)
dotnet build
```

## Usage

The `FrontendResourceProvider` class loads embedded resources at runtime:

```csharp
var stream = FrontendResourceProvider.GetResourceStream("app.index.html");
```

All files in `Resources/` are embedded into `Astrolune.UI.dll` as manifest resources.
