class DocumentStorage
{
    public void SaveDocument(string document)
    {
        Console.WriteLine("Document saved: " + document);
    }

    public string RetrieveDocument(int documentId)
    {
        return "Document with ID " + documentId;
    }
}

class DocumentTracking
{
    public void TrackDocument(int documentId)
    {
        Console.WriteLine("Document with ID " + documentId + " is being tracked.");
    }
}

class DocumentFlow
{
    public void SendToSecretary(string document) { Console.WriteLine("Document sent to Secretary: " + document); }


    public void SendToDirector(string document)
    {
        Console.WriteLine("Document sent to Director: " + document);
    }
}

class DocumentTrackingFacade
{
    private DocumentStorage _documentStorage;
    private DocumentTracking _documentTracking;
    private DocumentFlow _documentFlow;

    public DocumentTrackingFacade()
    {
        _documentStorage = new DocumentStorage();
        _documentTracking = new DocumentTracking();
        _documentFlow = new DocumentFlow();
    }

    public void StoreTrackSendDocument(string document)
    {
        _documentStorage.SaveDocument(document);
        int documentId = GenerateDocumentId();
        _documentTracking.TrackDocument(documentId);
        _documentFlow.SendToSecretary(document);
        _documentFlow.SendToDirector(document);
    }

    public string RetrieveDocument(int documentId)
    {
        return _documentStorage.RetrieveDocument(documentId);
    }

    public int GenerateDocumentId()
    {
        return new Random().Next(1000, 9999);
    }
}

class Program
{
    static void Main()
    {
        DocumentTrackingFacade facade = new DocumentTrackingFacade();

        string document = "Request Document";

        int randomDocumentId = facade.GenerateDocumentId();
        facade.StoreTrackSendDocument(document);

        string retrievedDocument = facade.RetrieveDocument(randomDocumentId);

        Console.WriteLine("Document received: " + retrievedDocument);
    }
}