# password-generator
I was unsatisfied with the passwords I was receiving from the password generation feature on Firefox, so I put together a basic script to generate a 20 character password with a good variety of symbols, letters, and numbers.

![image](https://user-images.githubusercontent.com/95886475/199999072-3acbeefa-e5cc-4d48-b0d5-4a3c195581f2.png)

The operation is very simple. Click generate, and a new password will appear. 

![image](https://user-images.githubusercontent.com/95886475/199999622-5db948e6-e1ae-403e-97ed-1c38d7b5d447.png)

I stored a set of possible characters in 4 different strings and placed those strings into an array.

![image](https://user-images.githubusercontent.com/95886475/199999871-d07f59ec-2b41-461b-bcb4-d08c43be7522.png)

When a password is generated, a string is randomly chosen, and then a character is randomly chosen from the string.
As the for-loop iterates, the selected character is added to the password string. Finally, the password is displayed in a selectable text-box.

If you are copy-pasting passwords on a Windows machine, be sure to clear your clipboard with `cmd /c "echo off | clip"`.

If you would like to modify or export the file, I would recommend using the [3.5.1](https://downloads.tuxfamily.org/godotengine/3.5.1/mono/) mono version of Godot and following the documentation for [exporting projects](https://docs.godotengine.org/en/stable/tutorials/export/exporting_projects.html).
