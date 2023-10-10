//�������
//�������� ��������������� �����, ������� ����� �������� �� ����� ���������� <div>.
//���� �����, ������ ��������� ��� div border ������� ����� �� ���������.
//���� ��� ���� ����� ������� my-border-color � ������ �������������� ���� border, ������������� ��� �������� ��������.

//������� 1
//�������� ������������� ��������������� �����, ������� ����� � ������������� �������������� ��� ������� <current-time>.
//�� ����� ���������� ���������� ���� ������� ������ ���������� �� ������� �����.
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