# Raffle

"Raffle" is a loose acronymic of "rapid HTML field scaffolding." I just made up the word "acronymic."

The reason for this I was about to build a large web form, and I realized it was going to be very laborious to build all the HTML fields in my Razor (.cshtml) manually. Certainly there's a scaffolding feature built into Visual Studio, but you can't customize it at all. I would end up adding all the Bootstrap class names manually, almost defeating the purpose of scaffolding in the first place.

So, I wanted a way to setup Razor templates for different field types that include all the special syntax that would otherwise be added manually. There's probably opportunities to include label and form-group divs which, again, are quite tedious to type manually -- particularly on large forms.

I wanted my app to be entirely template-driven with no hard-coded Bootstrap artifacts. In this example below, I would have "Bootstrap" as a template in the dropdown at the top, then provide some way to edit Bootstrap-specific field templates -- for example there would be checkbox and textbox templates.

![img](https://adamosoftware.blob.core.windows.net:443/images/raffle2.png)

String and bool are the only types I've setup so far, but you can see there's not much to them. These are setup to load from embedded resources, but ideally this should also load from the file system for easier end-user customization.

![img](https://adamosoftware.blob.core.windows.net:443/images/raffle3.png)
