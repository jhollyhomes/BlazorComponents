# Blazor Components
Some components for blazor written using tailwind css.

The controls are tightly coupled to tailwind but you could port to Bootstrap or whatever.

- Multi select drop down component
- Date picker component
- Colour picker
- Toggle button

Uses singleton state object as a Cascading Parameter that holds the state for colours.  The colours can be changed real time using the colour control.

**Controls with popups** use a bool field to show/hide then creates a hidden div to deal with close on button click outside.

- [X] Date picker component
- [X] Clear date option on date picker
- [X] Move components to a component project
- [X] Select month
- [X] Select year to month
- [X] Select 10 year to year to yonth
- [X] Make multiselect use hidden div same as date picker
- [ ] Add a from date - to date component
- [X] Add toggle component
- [X] Add colour selector
- [X] Add theme State to make colours same across controls
- [ ] Add colour controls for all colours
- [ ] Add labels for controls
- [ ] Add text box control
- [ ] Add currency control
- [ ] Add mulitline text control
- [ ] Add selector around selected controls
- [ ] Add place for validation message as part of label control or control wrapper

## Multiselect control

- ability to customise colours quickly
- Hides items after set number (in this case 3) and display Items Selected X message.

<img src="[https://your-image-url.type](https://github.com/jhollyhomes/BlazorComponents/assets/6323972/f996c6f9-1924-48c8-950b-2193f07c521c)" width="100">

## Date control
- ability to customise colours quickly
- Can change month year and ten years
![image](https://github.com/jhollyhomes/BlazorComponents/assets/6323972/fe70bfed-47bf-4a76-a9f8-dbdfd49be3f4)

## Toggle control
![image](https://github.com/jhollyhomes/BlazorComponents/assets/6323972/e56df648-5301-4706-8972-2ae034526a3c)

## Colour control
- Can select one of the tailwind colours (some removed as very similar but easy to add in)
![image](https://github.com/jhollyhomes/BlazorComponents/assets/6323972/7b4bca09-a7da-4012-b9d8-b9fe02c72e93)

