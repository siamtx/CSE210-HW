class PromptUser
{
    public string _date;
    public string _response;
    public string _prompt;

    public override string ToString()
    {
        return $"{_date} - {_prompt} - {_response}";
    }
}