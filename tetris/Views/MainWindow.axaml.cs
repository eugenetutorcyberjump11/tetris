using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Threading;
using System;

namespace tetris.Views;

public partial class MainWindow : Window
{
    private Game _game;
    private DispatcherTimer _gameTimer;

    public MainWindow()
    {
        InitializeComponent();
        _game = new Game(GameCanvas, ScoreButton_Click);
        _gameTimer = new DispatcherTimer();
        _gameTimer.Interval = TimeSpan.FromMilliseconds(500);
        _gameTimer.Tick += GameTick;

        this.KeyDown += MainWindow_KeyDown;
    }
    
    private void GameTick(object? sender, EventArgs e)
    {
        _game.MoveDown();
    }

    private void MainWindow_KeyDown(object? sender, KeyEventArgs e)
    {
        if (_game == null) return;

        switch (e.Key)
        {
            case Key.Left:
                _game.MoveLeft();
                break;
            case Key.Right:
                _game.MoveRight();
                break;
            case Key.Up:
                _game.Rotate();
                break;
            case Key.Down:
                _game.MoveDown();
                break;
        }
    }

    private void StartButton_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        _game.StartNewGame();
        _gameTimer.Start();
    }
}
