/*


+-----------------------------------+       The user opens the program and is given a welcome message.
|             Program               |       The user is then presented with 5 options:
+-----------------------------------+       1.) Add a journal ENtry.       
| - prompts: List<string>           |       The user enters a journal entrty after a prompt is given.
| - journal: Journal                |       2.) Display
+-----------------------------------+       The user is shown their current journal entries
| + Main(args: string[])            |       3.)Load a previously saved file
| + GetRandomPrompt(): string       |       The user is given the choice to open a previous journal entry
+-----------------------------------+       4.) Save File
            | 1                             The user Saves the file 
            |                               5.)Quit 
            |                               The user exits the journal app
            v
+-----------------------------------+
|             Journal               |
+-----------------------------------+
| - entries: List<Entry>            |
+-----------------------------------+
| + Journal()                       |
| + AddEntry(prompt: string)        |
| + DisplayEntries()                |
| + SaveToFile()                    |
| + LoadFromFile()                  |
+-----------------------------------+
            | 1
            |
            |
            v
 ___________________________________
|              Entry                |
+-----------------------------------+
| - _prompt: string                 |
| - _response: string               |
| - _date: string                   |
+-----------------------------------+
| + Entry(prompt: string,           |
|         response: string,         |
|         date: string)             |
| + GetPrompt(): string             |
| + GetResponse(): string           |
| + GetDate(): string               |
| + ToString(): string              |
|___________________________________|

*/