let logoutTimer:any;

export function activateAutoLogout(refreshTokenLifeTime: number, callback: () => void, thisArg: any) {
  clearTimer();
  if (refreshTokenLifeTime > 0) {
    logoutTimer = setTimeout(() => {
      callback.call(thisArg);
    }, refreshTokenLifeTime * 1000);
  }
}

export function deActivateAutoLogout() {
  clearTimer();
}

function clearTimer() {
  if (logoutTimer) {
    clearTimeout(logoutTimer);
  }
}
