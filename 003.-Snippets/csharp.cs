

{
  //NOTE : this file must be saved as csharp.json in the snippets folder
  // Each snippet is defined under 
  // a snippet name and has a prefix, body and 
  // description. 
  // The prefix is what is used to trigger the snippet 
  // and the body will be expanded and inserted. Possible variables are:
  // $1, $2 for tab stops, $0 for the final cursor position, 
  // and ${1:label}, ${2:another} for placeholders. Placeholders with the 
  // same ids are connected.
  // Example:
  "Print thread Id": {
    "prefix": "SirThreadId",
    "body": [
      "Console.WriteLine($\"The thread is { System.Threading.Thread.CurrentThread.ManagedThreadId}\");$0"
            Console.WriteLine($\" 
                                  { this.GetType().Namespace}.
                                  { this.GetType().Name}.
                                  { MethodBase.GetCurrentMethod().Name}
    { System.Threading.Thread.CurrentThread.ManagedThreadId}
    { System.DateTimeOffset.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}
                                  \");$0
            // Console.WriteLine("Current class: " + this.GetType().Name);
            // Console.WriteLine("Current method: " + MethodBase.GetCurrentMethod().Name); 
    ],
    "description": "Writes the current thread id to the console"
  }
}