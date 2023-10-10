//«адание
//—оздайте вспомогательный класс, который будет работать со всеми элементами <div>.
//Ётот класс, должен добавл€ть дл€ div border черного цвета по умолчанию.
//≈сли дл€ дива задан атрибут my-border-color Ц должен использоватьс€ цвет border, установленный как значение атрибута.

//«адание 1
//—оздайте дескрипторный вспомогательный класс, который будет в представлении использоватьс€ как элемент <current-time>.
//¬о врем€ выполнени€ приложени€ этот элемент должен заменитьс€ на текущее врем€.
namespace AspLesson8._2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

            app.Run();
        }
    }
}