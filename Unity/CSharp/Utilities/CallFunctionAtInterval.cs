/***********************************************
* Method to call a function at a given interval.
************************************************/
void CallFunctionAtInterval(string function, float startAt, float every)
{
    InvokeRepeating(function, startAt, every); // ex: Calls function DoSomething() after "startAt" seconds, and every "every" seconds
}

// Example function
void DoSomething()
{
    Debug.Log("DoSomething called");
}
