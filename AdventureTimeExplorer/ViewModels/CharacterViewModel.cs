using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureTimeExplorer.ViewModels;
public partial class CharacterViewModel : BaseViewModel
{
    // Observable collection with a provided notifications on add, delete, update
    public ObservableCollection<CharacterModel> Characters { get; } = new ObservableCollection<CharacterModel>();

    private readonly ICharactersService characterService;
    public CharacterViewModel(ICharactersService charactesService)
    {
        Title = "Character list";
        this.characterService = charactesService;
    }
    // creates a GetCharactersCommand to help handle events aka commands
    [ICommand]
    async Task GetCharactersAsync()
    {
        try
        {
            // indicate that process is going
            IsBusy = true;

            // get characters
            var characters = await characterService.GetCharacters();
            foreach (var character in characters)
            {
                Characters.Add(character);
            }
        }
        catch (Exception e)
        {
            await Shell.Current.DisplayAlert("Error! ", e.Message, "OK");
            throw;
        }
        finally
        {
            // indicate that process is finished
            IsBusy = false;
        }
    }
}
