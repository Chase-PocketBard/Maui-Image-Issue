# Maui-Image-Issue
Public repro project for .NET MAUI image loading issue on Android

## Description
An `Image` with a data-bound `Source` to an external URL loads while displayed, but when navigating away and back it disappears.

## Repro Steps
1. Clone project and build to an Android 12 (or later) device
2. Click the button to change the data-bound image source to a URL
3. Navigate to the other tab
4. Navigate back to the initial tab

Expected outcome:
- When first clicked, the new image loads
- When navigating away and back, the image that was last loaded should show up again

Actual outcome:
- When first clicked, the new image loads
- When navigating away and back, the image is blank
