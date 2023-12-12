# BlazorComponents
Some components for blazor written using tailwind css.

The controls are tightly coupled to tailwind but you could port to Bootstrap or whatever.

- Multi select drop down component
- Date picker component
- Colour picker
- Toggle button

Uses singleton state object as a Cascading Parameter that holds the state for colours.  The colours can be changed real time using the colour control.

**All Controls** use a bool field to show/hide then creates a hidden div to deal with close on button click outside.

- [X] Date picker component
- [X] Clear date option on date picker
- [X] Move components to a component project
- [X] Select Month
- [X] Select Year to Month
- [X] Select 10 Year to Year to Month
- [X] make Multiselect use hidden div same as date picker
- [ ] Add a from date - to date component
- [X] Add toggle component
- [X] Add Colour selector
- [ ] Add Theme State to make colours same across controls
