import { KayaTemplatePage } from './app.po';

describe('Kaya App', function() {
  let page: KayaTemplatePage;

  beforeEach(() => {
    page = new KayaTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
