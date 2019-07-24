# Prerequisites

- `npm i -g reveal-md`
- `npm i -g decktape`
- FiraCode

# Project structure

## TL/DR

### Starting the presentation

Linux/Mac:

```sh
./start.sh
```

Windows:

```bat
start.bat
```

### Creating a PDF version of the presentation

IMPORTANT: The script requires that the presentation is actively running in the browser (see previous section)!

Linux/Mac:

```sh
./create-pdf.sh
```

Windows:

```bat
./create-pdf.bat
```

## Initial setup

- ensure prerequisites are met
- `npm install`

## Details

This is a reveal-md project (see prerequisites).

To simplify things as writer, this project uses dedicated markdown files per "chapter" by using the `preproc.js` file. This is NOT standard reveal-md!

The `preproc.js` file allows using a main markdown file which includes other markdown files (for details see [https://github.com/webpro/reveal-md/issues/228](https://github.com/webpro/reveal-md/issues/228)).

For this to work you must follow the following instructions.

All markdown files must be in a dedicated folder (defined in `reveal-md.json`, currently: `slides`).

- any custom css must also be in that folder (`custom.css`)
- all images/resources must be in that folder.

The entry file is defined in `reveal-md.json`:

```json
{
    "preprocessor": "preproc.js",
    "includeDir": "slides",
    "_": ["slides/index.md"]
}
```

In the code above, the entry file is `slides/index.md`.

These settings are called from `./start.sh` (on linux) or `start.bat` (on windows).
Both invoke `npm start` from the file `package.json`, which in turn has further config settings...

Which calls the "top" settings from the first markdown file (`slides/index.md`). 
Which includes a section

```yaml
title: Some Title
theme: sky
revealOptions:
    transition: 'fade'
    controls: false
    progress: false
    autoPlayMedia: true
    transitionSpeed: slow
```

So... There are at least 3 files for configuration:

- `reveal-md.json`
- `package.json`
- `index.md`

Have fun.

I haven't figured out the best way to configure talks yet. The current solution works.

### Font Awesome

I manually copied the font-awesome folder to `slides` because I couldn't figure out another way of accessing the font through `reveal.html`...
