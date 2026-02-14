import { app, BrowserWindow } from 'electron';
import * as path from 'path';

let mainWindow: BrowserWindow | null = null;

function createWindow(): void {

    mainWindow = new BrowserWindow({
        width: 1200,
        height: 800
    });

    mainWindow.loadFile(
        path.join(__dirname, '../../FinWallet.Frontend/dist/FinWallet.Frontend/browser/index.html')
    );

    mainWindow.on('closed', () => {
        mainWindow = null;
    });
}

app.whenReady().then(createWindow);

app.on('window-all-closed', () => {
    if (process.platform !== 'darwin') {
        app.quit();
    }
});
