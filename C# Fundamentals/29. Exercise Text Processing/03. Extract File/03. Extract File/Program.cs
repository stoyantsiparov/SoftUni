string fileName = string.Empty;
string extension = string.Empty;

string filePath = Console.ReadLine();

int lastSeparatorIndex = filePath.LastIndexOf('\\');            // Намирам индекса на последната наклонената черта (така разделям само по една черта ('\'), но се пишат 2 ('\\'))
int extensionIndex = filePath.LastIndexOf(".");                 // Намирам индекса на последната точка


// Проверявам дали {lastSeparatorIndex} и {extensionIndex} са валидни (започват от 0)
if (lastSeparatorIndex != -1 &&
    extensionIndex != -1 &&
    extensionIndex > lastSeparatorIndex) //и дали {extensionIndex} е по-голям от {lastSeparatorIndex} -> индекса на ТОЧКАТА дали е по назад от индекса на НАКЛОНЕНАТА ЧЕРТА
{
    // Слагам {lastSeparatorIndex + 1}, за да взема първия елемент след чертата ('\')
    // Слагам {extensionIndex - lastSeparatorIndex - 1}, за да взема първия елемент след точката ('.')
    fileName = filePath.Substring(lastSeparatorIndex + 1, extensionIndex - lastSeparatorIndex - 1);     // Изваждам част от {string-а} в нова променлива

    extension = filePath.Substring(extensionIndex + 1);
}

Console.WriteLine($"File name: {fileName}");
Console.WriteLine($"File extension: {extension}");
