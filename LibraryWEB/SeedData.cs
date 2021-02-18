using LibraryWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryWEB
{
    public class SeedData
    {
        public static void Seed(LibraryContext context)
        {
            if (!context.Articles.Any())
            {
                Article a1 = new Article { Title = "Winter colds and small amounts", Date = new DateTime(2021, 2, 10), Text = "Winter colds and small amounts of sunshine make feel us weak. The stores of vitamins in the body are significantly reduced during the winter. Weather shifts can affect immunity. As a result, a lot of people feel unwell with the start of spring. The sun is shining, flowers blossom, temperatures are rising and nature awakens from winter sleep. Spring is a beautiful time, isn’t it? Along with positive changes, it’s also the time when our body lacks vitamins, that is so-called avitaminosis." };
                Article a2 = new Article { Title = "Self-discipline", Date = new DateTime(2021, 2, 11), Text = "Just understand that time is not your enemy but your friend. You can do so many things if you have goals and opportunities. The main thing is to organize yourself and your time correctly. It refers not only to work but also to other aspects of your life. Self-discipline is a key to success. A person who can’t control his life and be organized, so he can’t achieve the desired success. If you can’t achieve anything, it may cause stress, reduce productivity and disorganization. You get caught in a vicious circle!" };
                Article a3 = new Article { Title = "Emotions", Date = new DateTime(2021, 2, 11), Text = "Psychologists refer fear as a basic “emotion” that we experience it daily at work, at school, in the street, at home, everywhere. Fear mainly arises from 2 sources:  your personality and uncertainty. Many people are afraid of different things: water, height, pain, failure, death. They may have the same fear, but their behavior is shown in absolutely different ways: some people start to panic, other can’t control their emotions, etc. In this article we will talk about a common phobia called “stage fright”." };

                Article a4 = new Article { Title = "Winter colds and small amounts 2", Date = new DateTime(2021, 2, 12), Text = "Winter colds and small amounts of sunshine make feel us weak. The stores of vitamins in the body are significantly reduced during the winter. Weather shifts can affect immunity. As a result, a lot of people feel unwell with the start of spring. The sun is shining, flowers blossom, temperatures are rising and nature awakens from winter sleep. Spring is a beautiful time, isn’t it? Along with positive changes, it’s also the time when our body lacks vitamins, that is so-called avitaminosis." };
                Article a5 = new Article { Title = "Self-discipline 2", Date = new DateTime(2021, 2, 12), Text = "Just understand that time is not your enemy but your friend. You can do so many things if you have goals and opportunities. The main thing is to organize yourself and your time correctly. It refers not only to work but also to other aspects of your life. Self-discipline is a key to success. A person who can’t control his life and be organized, so he can’t achieve the desired success. If you can’t achieve anything, it may cause stress, reduce productivity and disorganization. You get caught in a vicious circle!" };
                Article a6 = new Article { Title = "Emotions 2", Date = new DateTime(2021, 2, 13), Text = "Psychologists refer fear as a basic “emotion” that we experience it daily at work, at school, in the street, at home, everywhere. Fear mainly arises from 2 sources:  your personality and uncertainty. Many people are afraid of different things: water, height, pain, failure, death. They may have the same fear, but their behavior is shown in absolutely different ways: some people start to panic, other can’t control their emotions, etc. In this article we will talk about a common phobia called “stage fright”." };

                Article a7 = new Article { Title = "Winter colds and small amounts 3", Date = new DateTime(2021, 2, 14), Text = "Winter colds and small amounts of sunshine make feel us weak. The stores of vitamins in the body are significantly reduced during the winter. Weather shifts can affect immunity. As a result, a lot of people feel unwell with the start of spring. The sun is shining, flowers blossom, temperatures are rising and nature awakens from winter sleep. Spring is a beautiful time, isn’t it? Along with positive changes, it’s also the time when our body lacks vitamins, that is so-called avitaminosis." };
                Article a8 = new Article { Title = "Self-discipline 3", Date = new DateTime(2021, 2, 14), Text = "Just understand that time is not your enemy but your friend. You can do so many things if you have goals and opportunities. The main thing is to organize yourself and your time correctly. It refers not only to work but also to other aspects of your life. Self-discipline is a key to success. A person who can’t control his life and be organized, so he can’t achieve the desired success. If you can’t achieve anything, it may cause stress, reduce productivity and disorganization. You get caught in a vicious circle!" };
                Article a9 = new Article { Title = "Emotions 3", Date = new DateTime(2021, 2, 14), Text = "Psychologists refer fear as a basic “emotion” that we experience it daily at work, at school, in the street, at home, everywhere. Fear mainly arises from 2 sources:  your personality and uncertainty. Many people are afraid of different things: water, height, pain, failure, death. They may have the same fear, but their behavior is shown in absolutely different ways: some people start to panic, other can’t control their emotions, etc. In this article we will talk about a common phobia called “stage fright”." };

                Comment c1 = new Comment { Name = "Pavlo Kalenyk", Date = new DateTime(2021, 2, 10) };
                Comment c2 = new Comment { Name = "Pavlo Kalenyk", Date = new DateTime(2021, 2, 11) };
                Comment c3 = new Comment { Name = "Pavlo Kalenyk", Date = new DateTime(2021, 2, 12) };

                Comment c4 = new Comment { Name = "Pavlo Kalenyk", Date = new DateTime(2021, 2, 13) }; 
                Comment c5 = new Comment { Name = "Pavlo Kalenyk", Date = new DateTime(2021, 2, 14) }; 
                Comment c6 = new Comment { Name = "Pavlo Kalenyk", Date = new DateTime(2021, 2, 14) }; 
                                                                                                    
                Comment c7 = new Comment { Name = "Pavlo Kalenyk", Date = new DateTime(2021, 2, 15) }; 
                Comment c8 = new Comment { Name = "Pavlo Kalenyk", Date = new DateTime(2021, 2, 15) };
                Comment c9 = new Comment { Name = "Pavlo Kalenyk", Date = new DateTime(2021, 2, 15) }; 

                CommentText commentText = new CommentText { Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",  Comment = c1 };
                CommentText commentText1 = new CommentText { Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Comment = c2 };
                CommentText commentText2 = new CommentText { Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Comment = c3 };
                CommentText commentText3 = new CommentText { Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Comment = c4 };
                CommentText commentText4 = new CommentText { Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Comment = c5 };
                CommentText commentText5 = new CommentText { Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Comment = c6 };
                CommentText commentText6 = new CommentText { Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Comment = c7 };
                CommentText commentText7 = new CommentText { Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Comment = c8 };
                CommentText commentText8 = new CommentText { Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", Comment = c9 };

                Questionnaire questionnaire = new Questionnaire();
                
                questionnaire.FirstName = "Pavlo";
                questionnaire.LastName = "Kalenyk";

                QuestionnaireAnswer questionnaireAnswer = new QuestionnaireAnswer();
                
                questionnaireAnswer.Answer = "Fantastic";

                QuestionnaireAnswer questionnaireAnswer2 = new QuestionnaireAnswer();
                
                questionnaireAnswer2.Answer = "English";

                QuestionnaireAnswer questionnaireAnswer3 = new QuestionnaireAnswer();
                
                questionnaireAnswer3.Answer = "Yes";

                questionnaire.QuestionnaireAnswers.Add(questionnaireAnswer);
                questionnaire.QuestionnaireAnswers.Add(questionnaireAnswer2);
                questionnaire.QuestionnaireAnswers.Add(questionnaireAnswer3);

                Tag t1 = new Tag { Name = "news" };
                Tag t2 = new Tag { Name = "2020" };
                Tag t3 = new Tag { Name = "cool" };

                t1.Articles = new List<Article> { a1, a2, a7, a8, a9 };
                t2.Articles = new List<Article> { a2, a4, a5, a6 };
                t3.Articles = new List<Article> { a3, a4, a5, a6 };

                context.Articles.AddRange(a1, a2, a3, a4, a5, a6, a7, a8, a9);

                context.Comments.AddRange(c1, c2, c3, c4, c5, c6, c7, c8, c9);

                context.CommentText.AddRange(commentText, commentText1, commentText2, commentText3, commentText4, commentText5, commentText6, commentText7, commentText8);

                context.Tags.Add(t1);
                context.Tags.Add(t2);
                context.Tags.Add(t3);

                context.Questionnaires.Add(questionnaire);

                context.SaveChanges();
            }
        }
    }
}
