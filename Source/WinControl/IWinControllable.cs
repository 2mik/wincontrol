/*
 * Разработчик:
 * 2010, Ширяев Михаил
 */

namespace WinControl
{
    /// <summary>
    /// Предоставляет возможность окну контролироваться элементом управления WinControl
    /// </summary>
    public interface IWinControllable
    {
        /// <summary>
        /// Получить или установить информацию о контролируемом окне
        /// </summary>
        WinInfo WinInfo { get; set; }

        /// <summary>
        /// Сохранить изменения данных контролируемого окна
        /// </summary>
        void Save();
    }
}
