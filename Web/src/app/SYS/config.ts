export class Config {

//#region Propiedades
  apiurl : string | undefined
//#endregion

//#region Singleton
  private static _current : Config  
  public static get Current() : Config {
    if (!this._current)
      this._current = this.LoadConfig()
    return this._current
  }
  //#endregion
  
  private static LoadConfig() : Config
  {
    let config = new Config()
    config.apiurl = 'https://localhost:44313/'

    return config
  }  
}