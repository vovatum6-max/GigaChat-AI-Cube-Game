using UnityEngine;
using System.Collections;

public class GigaChatCubeManager : MonoBehaviour
{
    // ТУТ БУДУТ НАСТРОЙКИ ДЛЯ ИНТЕРФЕЙСА (UI)
    // Поле ввода текста (InputField) и текстовое поле для ответов ИИ

    // ТУТ БУДУТ НАСТРОЙКИ ДЛЯ КУБИКА
    // Ссылка на Rigidbody2D кубика, чтобы менять его физику на лету

    void Start()
    {
        // Инициализация игры, проверка подключения к API GigaChat
    }

    // МЕТОД ДЛЯ ОТПРАВКИ ТЕКСТА ПОЛЬЗОВАТЕЛЯ В GIGACHAT
    public void SendRequestToGigaChat(string userText)
    {
        // 1. Формируем JSON-запрос со строгим системным промтом.
        // 2. Используем UnityWebRequest для асинхронной отправки данных.
        // 3. Ждем ответ от сервера Сбера.
    }

    // МЕТОД ДЛЯ ПАРСИНГА ОТВЕТА И ПОИСКА ТРИГГЕР-СЛОВ
    private void ParseAIResponse(string jsonResponse)
    {
        // Извлекаем чистый текст из ответа GigaChat.
        // Если текст содержит "прыгай" -> вызываем метод CubeJump().
        // Если текст содержит "мост" -> спавним префаб платформы.
        // Если текст содержит "быстро" -> увеличиваем скорость кубика.
    }

    // МЕТОДЫ ПОВЕДЕНИЯ КУБИКА И СПАВНА ОБЪЕКТОВ
    private void CubeJump()
    {
        // Код для прикладывания силы (Force) к Rigidbody2D кубика вверх
    }

    private void SpawnPlatform()
    {
        // Код для Instantiate(platformPrefab) перед кубиком
    }
}
